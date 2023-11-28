using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp148
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Graphics g;
            g = this.CreateGraphics();
            Point p1 = new Point(100, 100);
            Point p2 = new Point(200, 100);
            Pen pe = new Pen(System.Drawing.Color.Red, 5);
            pe.DashStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            pe.EndCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor;
            g.DrawLine(pe, p1, p2);
        }
    }
}
