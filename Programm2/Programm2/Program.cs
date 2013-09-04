using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programm2
{
    /// <summary>
    /// 10.	Даны координаты трех точек на плоскости.
    /// Если они могут быть вершинами остроугольного треугольника,
    /// вывести их в порядке убывания, вычислить площадь полученного треугольника.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = Input("x1:");
            double y1 = Input("y1:");
            double x2 = Input("x2:");
            double y2 = Input("y2:");
            double x3 = Input("x3:");
            double y3 = Input("y3:");
            double a = len(x1, y1, x2, y2);
            double b = len(x3, y3, x2, y2);
            double c = len(x1, y1, x3, y3);
            bool l1 = cosinus(a, b, c);
            bool l2 = cosinus(b, a, c);
            bool l3 = cosinus(c, a, b);
            if (a < b + c && b < a + c && c < a + b)
            {
                if (l1 && l2 && l3)
                {
                    double s = Geron(a, b, c);

                    Console.WriteLine("Да, площадь - " + s.ToString());
                    Console.ReadKey();

                }
                else
                    Console.Write("Треугольник не остроугольный");
                Console.ReadKey();
            }

        }

        private static double Geron(double a, double b, double c)
        {
            double p = (a + b + c) / 2;
            double s = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            return s;
        }

        private static bool cosinus(double a, double b, double c)
        {
            double z = (a * a + b * b - c * c) / (2 * a * b);
            if ((z > 0) && (z < 1))
            {
                return true;
            }
            else
            {
                return false;
            }
        }



        private static double len(double x1, double y1, double x2, double y2)
        {
            double a = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
            return a;
        }



        private static double Input(string p)
        {
            double a;
            Console.Write("Введите координату {0}", p);
            while (true)
            {
                if (double.TryParse(Console.ReadLine(), out a))
                {
                    return a;
                }
                else
                {
                    Console.Write("Ввелите действительное число");
                }
            }

        }
    }
}
