using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programm2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            pictureBox1.Image = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            Graphics g = pictureBox1.CreateGraphics();
            g.Clear(Color.White);

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


            Graphics g = Graphics.FromImage(pictureBox1.Image);
            Pen blackPen = new Pen(Color.Black, 2);
            Pen grayPen = new Pen(Color.Gray, 2);
            Pen greenPen = new Pen(Color.Green, 1);
            Font myFont =new Font("Tahoma", 20);
            g.Clear(Color.White);
            //Монитор
            g.FillRectangle(Brushes.Black, 100, 60, 170, 120);
            g.FillRectangle(Brushes.GreenYellow, 110, 70, 150, 100);
            g.FillRectangle(Brushes.Black, 175, 180, 20, 20);
            g.DrawRectangle(grayPen, 100, 60, 170, 120);
            g.FillRectangle(Brushes.Black, 135, 200, 100, 4);

            g.DrawString("Asus", myFont, System.Drawing.Brushes.Black, 155, 100);
            //Системник
            g.FillRectangle(Brushes.Black, 300, 10, 90, 194);
            g.DrawRectangle(grayPen, 300, 10, 90, 194);
            g.DrawRectangle(grayPen, 305, 14, 80, 20);
            g.DrawRectangle(grayPen, 305, 38, 80, 20);
            g.DrawRectangle(grayPen, 305, 62, 80, 20);
            g.DrawRectangle(grayPen, 320, 86, 50, 15);
            g.FillEllipse(Brushes.DarkSlateGray, 341, 110, 10, 10);
            g.DrawEllipse(greenPen, 341, 110, 10, 10);
            g.FillEllipse(Brushes.Gray, 342, 125, 8, 8);


            g.FillEllipse(Brushes.Red, 320, 110, 5, 5);
            g.FillEllipse(Brushes.Green, 365, 110, 5, 5);
            


            pictureBox1.Refresh();
        }
    }
}
