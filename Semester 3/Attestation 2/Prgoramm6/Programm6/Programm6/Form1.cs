using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programm6
{/*
  Создать инструмент для рисования линий уровня. 
  * Этот проект должен позволять вводить функцию 
  * двух переменных либо в аналитическом виде,
  * либо в табличном - значениями в узловых точках. 
  * Если функция вводится в аналитическом виде, 
  * то вам понадобится интерпретатор, на худой
  * конец можно менять исходный текст и перетранслировать его.
  * В случае табличного задания функции придётся применять 
  * подходящую двумерную интерполяцию. Должна быть предусмотрена 
  * возможность изменять прямоугольник проектирования и число 
  * линий уровня. Рекомендуется кроме линий применить подкраску:
  * определённому промежутку изменения значений функции поставить
  * в соответствие некоторый цвет и этим цветом закрасить область
  * между линиями уровня, так, как это делают на топографических
  * картах (чем ниже - тем зеленее, чем выше - тем коричневее).
  */

    public partial class Form1 : Form
    {
        Color[] color = new Color[10];
        HashSet<Point> pressed = new HashSet<Point>();
        List<layer> set = new List<layer>();

        bool activationForm = false;
        public Form1()
        {

            InitializeComponent();
            pictureBox1.Image = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            Graphics g = pictureBox1.CreateGraphics();
            g.Clear(Color.White);
            pictureBox1.Refresh();

        }



        private void Form1_Load(object sender, EventArgs e)
        {
            Graphics g = Graphics.FromImage(pictureBox1.Image);
            g.Clear(Color.White);
            color[0] = Color.FromArgb(0, 255, 0);
            color[1] = Color.FromArgb(0, 180, 0);
            color[2] = Color.FromArgb(0, 90, 0);
            color[3] = Color.FromArgb(90, 130, 0);
            color[4] = Color.FromArgb(140, 130, 0);
            color[5] = Color.FromArgb(180, 130, 0);
            color[6] = Color.FromArgb(220, 130, 0);
            color[7] = Color.FromArgb(160, 80, 0);
            color[8] = Color.FromArgb(160, 35, 0);
            color[9] = Color.FromArgb(125, 40, 0);
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            button2.Visible = true;
            trackBar1.Visible = true;
            label2.Visible = true;
            activationForm = true;

            label1.Text = "Режим редактирования: ВКЛ";

        }

        private void button2_Click(object sender, EventArgs e)
        {

            Point[] curvePoints = new Point[pressed.Count];
            pressed.CopyTo(curvePoints);

            set.Add(new layer((int)trackBar1.Value,curvePoints));
            Sorting(set);
            pressed.Clear();
            



            Graphics g = Graphics.FromImage(pictureBox1.Image);
            Pen blackPen = new Pen(Color.Black, 1);
            g.Clear(Color.White);

            for (int i = 0; i < set.Count; i++)
            {
                g.FillPolygon(new SolidBrush(color[set[i].Level]), set[i].Pt);
            }

            //Point point1 = new Point(10,20);
            //Point[] curvePoints = { new Point(10, 20), new Point(100, 100), new Point(210, 110) };

            // g.FillPolygon(new SolidBrush(color[trackBar1.Value]), curvePoints);
            pictureBox1.Refresh();
            button2.Visible = false;
            trackBar1.Visible = false;
            label2.Visible = false;
            activationForm = false;
            label1.Text = "Режим редактирования: ВЫКЛ";
        }

        private void Sorting(List<layer> set)
        {
            for (int i = 0; i<set.Count-1;i++)
                for (int j = 0; j < set.Count-1; j++)
                    if (set[i].Level>set[i+1].Level)
                    {
                        layer temp = set[i];
                        set[i] = set[i + 1];
                        set[i + 1] = temp;
                    }
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            label3.Text = Convert.ToString(e.X) + " " + Convert.ToString(e.Y);
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (activationForm)
            {
                pressed.Add(new Point(Convert.ToInt32(e.X), Convert.ToInt32(e.Y)));
            }
        }




    }
    public class layer
    {
        private int level;

        public int Level
        {
            get { return level; }
            set { level = value; }
        }


        private Point[] pt;

        public Point[] Pt
        {
            get { return pt; }
            set { pt = value; }
        }




        public layer(int level, Point[] pt)
        {
            this.level = level;
            this.pt = pt;
        }



    }
}
