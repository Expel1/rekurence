using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rekurence
{
    public partial class Form1 : Form
    {
        List<Line> lines = new List<Line>();
        
        public Form1()
        {
            InitializeComponent();

            CreateBrunch(350, 200);
            Invalidate();
        }

        public void CreateBrunch(int x, int y)
        {
            //levo
            Line line1 = new Line();
            line1.x1 = x;
            line1.y1 = y;
            line1.x2 = line1.x1 - 10;
            line1.y2 = line1.y1 - 10;
            line1.color = Color.Red;
            lines.Add(line1);
            //pravo
            Line line2 = new Line();
            line2.x1 = x;
            line2.y1 = y;
            line2.x2 = line1.x1 + 10;
            line2.y2 = line1.y1 - 10;
            line2.color = Color.Red;
            lines.Add(line2);

        }
        
        private void OnPaint(object sender, PaintEventArgs e)
        {
            foreach (Line line in lines)
            {
                e.Graphics.DrawLine(new Pen(Color.Red, 5), line.x1, line.y1, line.x2, line.y2);
            }
           
        }
    }
}
