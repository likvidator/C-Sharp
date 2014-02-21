using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programm3
{
    public partial class Form1 : Form
    {
        int[] x1 = new int[5];
        int[] y1 = new int[5];
        int[] x2 = new int[5];
        int[] y2 = new int[5];
        Point[] f1 = new Point[5];
        Point[] f2 = new Point[5];
        int n = 0;
        public Form1()
        {
            InitializeComponent();
            pictureBox1.Image = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            Graphics g = pictureBox1.CreateGraphics();
            g.Clear(Color.White);
            pictureBox1.Refresh();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            Graphics g = Graphics.FromImage(pictureBox1.Image);
            Pen redPen = new Pen(Color.Red, 1);
            Pen blackPen = new Pen(Color.Black, 1);
            g.TranslateTransform(pictureBox1.Size.Width / 2, pictureBox1.Size.Height / 2);
            g.Clear(Color.White);
            g.DrawLine(blackPen, -pictureBox1.Size.Width / 2, 0, pictureBox1.Size.Width / 2, 0);
            g.DrawLine(blackPen, 0, -pictureBox1.Size.Height / 2, 0, pictureBox1.Size.Height / 2);

            for (int i = 0; i < x1.Length; i++)
            {
                if (((f1[i].Y < f2[i].Y)&&(f1[i].X >= f2[i].X)))
               //if (((f1[i].Y > f2[i].Y) && (f1[i].X <= f2[i].X)) || ((f1[i].Y < f2[i].Y) && (f1[i].X >= f2[i].X)))
                    f1[i].Y = f1[i].Y + 1;
            }
            g.Clear(Color.White);
            g.DrawLine(blackPen, -pictureBox1.Size.Width / 2, 0, pictureBox1.Size.Width / 2, 0);
            g.DrawLine(blackPen, 0, -pictureBox1.Size.Height / 2, 0, pictureBox1.Size.Height / 2);
            g.DrawCurve(blackPen, f2);
            g.DrawCurve(redPen, f1);
            pictureBox1.Refresh();
            n += 1;




        }
        void button1_Click(object sender, EventArgs e)
        {

            int d;
            d = x1.Length / 2 * (-1);
            for (int i = x1.Length - 1; i > -1; i--)
            {
                x1[i] = 10 * d;
                y1[i] = x1[i] * x1[i]+4;

                d += 1;
            }
            d = x2.Length / 2 * (-1);
            for (int i = x2.Length - 1; i > -1; i--)
            {
                x2[i] = 100 * d;
                y2[i] =  x2[i] * x2[i]  -20;

                d += 1;
            }
            for (int i = 0; i < x1.Length; i++)
            {
                f1[i].X = x1[i];
                f1[i].Y = y1[i] * (-1);
            }
            for (int i = 0; i < x2.Length; i++)
            {
                f2[i].X = x2[i];
                f2[i].Y = y2[i] * (-1);
            }
            Graphics g = Graphics.FromImage(pictureBox1.Image);
            g.Clear(Color.White);
            Pen blackPen = new Pen(Color.Black, 1);

            g.TranslateTransform(pictureBox1.Size.Width / 2, pictureBox1.Size.Height / 2);
            g.DrawLine(blackPen, -pictureBox1.Size.Width / 2, 0, pictureBox1.Size.Width / 2, 0);
            g.DrawLine(blackPen, 0, -pictureBox1.Size.Height / 2, 0, pictureBox1.Size.Height / 2);
            g.DrawCurve(blackPen, f1);
            g.DrawCurve(blackPen, f2);
            pictureBox1.Refresh();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Resize(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            label1.Text = Convert.ToString(System.Windows.Forms.Cursor.Position.X - 12 - 86 + 52 - pictureBox1.Size.Width / 2) + " " + Convert.ToString(System.Windows.Forms.Cursor.Position.Y - 12 + 51 - pictureBox1.Size.Height / 2 - 109);
        }

    }
}
