using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CG_task1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            picture.Image = new Bitmap(picture.Width, picture.Height);
            Graphics g = picture.CreateGraphics();
            g.Clear(Color.White);
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            Graphics g = Graphics.FromImage(picture.Image);
            Pen blackPen = new Pen(Color.Black, 2);
                
            // body
            g.FillRectangle(Brushes.Blue, 130, 60, 210, 250);
            g.DrawRectangle(blackPen, 130, 60, 210, 250);

            //// T-short
            //g.FillRectangle(Brushes.White, 130, 240, 210, 50);
            //g.DrawRectangle(blackPen, 130, 240, 210, 50);
            //g.FillRectangle(Brushes.White, 95, 220, 35, 20);
            //g.DrawRectangle(blackPen, 95, 220, 35, 20);
            //g.FillRectangle(Brushes.White, 340, 220, 35, 20);
            //g.DrawRectangle(blackPen, 340, 220, 35, 20);
            
            //// pants
            //g.FillRectangle(Brushes.Brown, 130, 290, 210, 50);
            //g.DrawRectangle(blackPen, 130, 290, 210, 50);
            //g.FillRectangle(Brushes.Brown, 165, 340, 35, 20);
            //g.DrawRectangle(blackPen, 165, 340, 35, 20);
            //g.FillRectangle(Brushes.Brown, 270, 340, 35, 20);
            //g.DrawRectangle(blackPen, 270, 340, 35, 20);

            //// left eye
            //g.FillEllipse(Brushes.White, 250, 100, 60, 65);
            //g.FillEllipse(Brushes.Blue, 257, 115, 45, 45);
            //g.DrawEllipse(blackPen, 250, 100, 60, 65);
            //g.DrawEllipse(blackPen, 257, 115, 45, 45);

            //// right eye
            //g.FillEllipse(Brushes.White, 160, 100, 60, 65);
            //g.FillEllipse(Brushes.Blue, 167, 115, 45, 45);
            //g.DrawEllipse(blackPen, 160, 100, 60, 65);
            //g.DrawEllipse(blackPen, 167, 115, 45, 45);
            //g.FillEllipse(Brushes.Black, 180, 130, 20, 20);
            //g.FillEllipse(Brushes.Black, 270, 130, 20, 20);

            //// nose
            //g.FillEllipse(Brushes.Yellow, 227, 165, 16, 16);
            //g.DrawEllipse(blackPen, 227, 165, 16, 16);

            //// mouth
            //g.DrawLine(blackPen, 200, 200, 270, 200);

            //// hands 
            //g.FillRectangle(Brushes.Yellow, 110, 240, 10, 100);
            //g.DrawRectangle(blackPen, 110, 240, 10, 100);
            //g.FillRectangle(Brushes.Yellow, 105, 320, 20, 30);
            //g.DrawRectangle(blackPen, 105, 320, 20, 30);
            //g.FillRectangle(Brushes.Yellow, 350, 240, 10, 100);
            //g.DrawRectangle(blackPen, 350, 240, 10, 100);
            //g.FillRectangle(Brushes.Yellow, 345, 320, 20, 30);
            //g.DrawRectangle(blackPen, 345, 320, 20, 30);

            //// foots
            //g.FillRectangle(Brushes.Yellow, 175, 360, 15, 90);
            //g.DrawRectangle(blackPen, 175, 360, 15, 90);
            //g.FillRectangle(Brushes.Yellow, 280, 360, 15, 90);
            //g.DrawRectangle(blackPen, 280, 360, 15, 90);
            //g.FillRectangle(Brushes.Black, 165, 450, 35, 25);
            //g.DrawRectangle(blackPen, 165, 450, 35, 25);
            //g.FillRectangle(Brushes.Black, 270, 450, 35, 25);
            //g.DrawRectangle(blackPen, 270, 450, 35, 25);
            picture.Refresh();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Graphics g = picture.CreateGraphics();
            g.Clear(Color.White);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void picture_Click(object sender, EventArgs e)
        {

        }
    }
}
