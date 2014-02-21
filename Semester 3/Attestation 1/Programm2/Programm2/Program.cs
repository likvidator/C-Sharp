using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programm2
{
    /// <summary>
    /// 10.Проверить истинность высказывания: «Данное четырехзначное число читается одинаково слева направо и справа налево». 
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            int a = Input("a:");
            int x1 = a % 10;
            a = a / 10;
            int x2 = a % 10;
            a = a / 10;
            int x3 = a % 10;
            a = a / 10;
            int x4 = a;
            if ((x1 == x4) && (x2 == x3))
            {
                Console.Write("Число зеркально");
                Console.ReadKey();
            }
            else
                Console.Write("Число не зеркально");
            Console.ReadKey();



        }

        private static int Input(string p)
        {
            int a;
            Console.Write("Введите число {0}", p);
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out a))
                {
                    if ((a > 999) && (a < 10000))

                        return a;
                    else
                        Console.Write("Введите четырехзначное число");

                }
                else
                {
                    Console.Write("Ввеите действительное число");
                }
            }

        }
    }
}
