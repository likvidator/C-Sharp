using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programm5
{
    public partial class Form1 : Form
    {
        private static HashSet<Keys> pressedKeys = new HashSet<Keys>();

        public static HashSet<Keys> PressedKeys
        {
            get { return pressedKeys; }
        }

        public Form1()
        {
            InitializeComponent();
            pictureBox1.Image = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            Graphics g = pictureBox1.CreateGraphics();
            g.Clear(Color.White);
           
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            label1.Text = e.KeyData.ToString();
            pressedKeys.Add(e.KeyData);
            this.Invalidate();
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            pressedKeys.Remove(e.KeyData);
            label1.Text = e.KeyData.ToString();
            this.Invalidate();

        }

        protected override void OnPaint(PaintEventArgs e)
        {


            String str = "";
            foreach (var a in pressedKeys.ToList())
            {
                str += a.ToString() + " ";
            }
            label1.Text = str;
        }
        int d = 20, s = 20, up = 100,left=100;
        private void timer1_Tick(object sender, EventArgs e)
        {
            Graphics g = Graphics.FromImage(pictureBox1.Image);
            Pen blackPen = new Pen(Color.Black, 2);
            Pen grayPen = new Pen(Color.Gray, 2);
            Pen greenPen = new Pen(Color.Green, 1);
            Font myFont = new Font("Jokerman", 20);
            g.Clear(Color.White);
            //Монитор
            foreach (var x in pressedKeys.ToList())
            {
                if (x.ToString() == "D")
                {
                    d += 5;
                }
                if (x.ToString() == "A")
                {
                    d -= 5;
                }
                if (x.ToString() == "W")
                {
                    s -= 5;
                }
                if (x.ToString() == "S")
                {
                    s += 5;
                }
                if (x.ToString() == "Right")
                {
                    left += 15;
                }
                if (x.ToString() == "Left")
                {
                    left -= 15;
                }
                if (x.ToString() == "Up")
                {
                    up -= 15;
                }
                if (x.ToString() == "Down")
                {
                    up += 15;
                }
            }
            g.FillEllipse(Brushes.Red, left, up, 30, 30);
            g.FillRectangle(Brushes.Black, d, s, 15, 15);
            
            pictureBox1.Refresh();

            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }





    }
}
