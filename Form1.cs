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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Graphics g = CreateGraphics();
                string  x_cord = e.X.ToString();
                string  y_cord = e.Y.ToString();
                string s =x_cord+ ";"+y_cord;
                g.DrawString(s, new Font("Times New Roman", 8),
                new SolidBrush(Color.Black), new Point(e.X, e.Y));
            }
            else if (e.Button == MouseButtons.Right) 
            {
                string frame_name = "Правая кнопка мыши";
                MessageBox.Show("Нажата правая кнопка мыши", frame_name);
                Graphics g = CreateGraphics();
                g.Clear(Color.White);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void windowsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void новоеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new Form2();
            f.MdiParent = this;
            f.Text = "New Frame " + this.MdiChildren.Length.ToString();
            f.Show();
        }
    }
}
