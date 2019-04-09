using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RainEngine
{
    public partial class Form1 : Form
    {
        Graphics graph;

        Point First_pos;
        Point Current_pos;
        Pen ColourPen = new Pen(Color.Black, 3);

        public Form1()
        {
            InitializeComponent();
            graph = pictureBox1.CreateGraphics();

        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            First_pos.X = e.X;
            First_pos.Y = e.Y;
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            graph.DrawEllipse(ColourPen, First_pos.X, First_pos.Y, Current_pos.X - First_pos.X, Current_pos.Y - First_pos.Y);
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Left)
            {
                Current_pos.X = e.X;
                Current_pos.Y = e.Y;
                graph.Clear(Color.White);
                graph.DrawEllipse(ColourPen, First_pos.X, First_pos.Y, Current_pos.X - First_pos.X, Current_pos.Y - First_pos.Y);
            }
        }
    }
}
