using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tao.OpenGl;
using Tao.FreeGlut;
using Tao.Platform.Windows;
using Tao.FreeGlut;

namespace Programm4
{
    public partial class Form1 : Form
    {
        double x = 0;
        public Form1()
        {
            InitializeComponent();
            simpleOpenGlControl1.InitializeContexts();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // инициализация Glut
            
            Glut.glutInit();
            Glut.glutInitDisplayMode(Glut.GLUT_RGB | Glut.GLUT_DOUBLE | Glut.GLUT_DEPTH);

            // очитка окна
            Gl.glClearColor(255, 255, 255, 1);

            // установка порта вывода в соотвествии с размерами элемента anT
            Gl.glViewport(0, 0, simpleOpenGlControl1.Width, simpleOpenGlControl1.Height);


            // настройка проекции
            Gl.glMatrixMode(Gl.GL_PROJECTION);
            Gl.glLoadIdentity();
            Glu.gluPerspective(45, (float)simpleOpenGlControl1.Width / (float)simpleOpenGlControl1.Height, 0.1, 200);
            Gl.glMatrixMode(Gl.GL_MODELVIEW);
            Gl.glLoadIdentity();
            
            // настройка параметров OpenGL для визуализации
            Gl.glEnable(Gl.GL_DEPTH_TEST);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {


            Gl.glClear(Gl.GL_COLOR_BUFFER_BIT | Gl.GL_DEPTH_BUFFER_BIT);

            Gl.glLoadIdentity();
            Gl.glColor3f(0, 1.0f, 0);

            //Gl.glPushMatrix();
            Gl.glTranslated(1, 0, -10 );
            Gl.glRotated(1, 1, 0, 1);

            // рисуем сферу с помощью библиотеки FreeGLUT
            //Glut.glutWireSphere(3, 20, 20);
            Gl.glColor3f(0, 0, 1.0f);
            //Glut.glutWireIcosahedron();
            Glut.glutStrokeString(Glut.GLUT_STROKE_MONO_ROMAN, "awsdawdawdawd");
            Glut.glutInitDisplayString("qwewqe");
           
            //Glut.glutWireCube(1);

            Gl.glFlush();
            simpleOpenGlControl1.Invalidate();
            //x += trackBar1.Value;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}