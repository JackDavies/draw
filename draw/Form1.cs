using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace draw
{
    public partial class Form1 : Form
    {
        Graphics g;
        Pen p = new Pen(Color.Blue);
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            g = pictureBox1.CreateGraphics();

            resize_form();
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            g.DrawLine(p, new Point(10, 10), new Point(170, 190));
        }
        private void resize_form() {
            panel2.Width = this.Width;
            panel2.Height = this.Height;
            pictureBox1.Left = 0;
            pictureBox1.Top = 0;
            pictureBox1.Width = panel2.Width-110;
            pictureBox1.Height = panel2.Height-80;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            resize_form();
        }
    }
}
