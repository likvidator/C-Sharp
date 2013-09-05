using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programm_3
{
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
            double l1 = len(x1, y1, x2, y2);
            double l2 = len(x1, y1, x3, y3);
            double l3 = len(x2, y2, x3, y3);
            if ((l1 * l1 == l2 * l2 + l3 * l3) || (l2 * l2 == l1 * l1 + l3 * l3) || (l3 * l3 == l2 * l2 + l1 * l1))
            //Проверка что угол прямой по теореме пифагора
            {
                Console.WriteLine("x={0},y={1}", x3 - x1 + x2, y3 - y1 + y2);
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Прямоугольника не существует");
                Console.ReadKey();
            }
            
            

        }

        private static double len(double x1, double y1, double x2, double y2)
        {
            double l = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
            return l;
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
                    Console.Write("Ввеите действительное число");
            }
        }
    }
}
