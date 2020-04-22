using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinAPp
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        bool start = false;
        private int x, y, x1, y1, q, primaryX, primaryY;
        static Graphics g;

        private void Form2_MouseDown(object sender, MouseEventArgs e)
        {
          if (e.Button == MouseButtons.Left)
            {
                start = true;
                x = e.X;
                y = e.Y;
                x1 = e.X;
                y1 = e.Y;
                primaryX = e.X;
                primaryY = e.Y;
            }
          
        }

        private void Form2_MouseMove(object sender, MouseEventArgs e)
        {
            g = CreateGraphics();
            if (start == true)
            {
                Pen penclear = new Pen(Color.White, 3);
                Rectangle rclear = Rectangle.FromLTRB(x, y, x1, y1);
                g.DrawRectangle(penclear, rclear);
                x = primaryX;
                y = primaryY;
                x1 = e.X;
                y1 = e.Y;
                if (x > x1)
                {
                    q = x;
                    x = x1;
                    x1 = q;
                }
                if (y > y1)
                {
                    q = y;
                    y = y1;
                    y1 = q;
                }
                Pen pen = new Pen(Color.HotPink, 2);
                Rectangle rdash = Rectangle.FromLTRB(x, y, x1, y1);
                pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
                g.DrawRectangle(pen, rdash);
            }


        }

        private void Form2_MouseUp(object sender, MouseEventArgs e)
        {
            start = false;
            Rectangle finalr = Rectangle.FromLTRB(x, y, x1, y1);
            Pen pen1 = new Pen(Color.White, 2);
            g.DrawRectangle(pen1, finalr);

            Pen pen = new Pen(Color.HotPink, 2);
            g.DrawRectangle(pen, finalr);
            g.Dispose();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
