using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programm1
{
    /// <summary>
    /// Даны два ненулевых числа, найти сумму, разность, произведение,частность.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            double a= Input("a");
            double b = Input("b");

            Console.WriteLine("Сумма: {0}",a+b);
            Console.WriteLine("Разность: {0}", a - b);
            Console.WriteLine("Произведение: {0}", a * b);
            Console.WriteLine("Частность: {0}", a / b);
            Console.WriteLine("Частность: {0}",b/a);
            Console.ReadLine();
            

        }

        private static double Input(string p)
        {
            double a;
            Console.Write("Input {0}:",p);
            while (true)
            {
                if (double.TryParse(Console.ReadLine(), out a))
                {

                    if (a != 0)
                    {
                        return a;
                    }
                    else
                    {
                        Console.WriteLine("Число равно нулю ");
                    }
                }
                else
                {
                    Console.WriteLine("Введите действительное число ");
                }
            }
            return 0;
        }
    }
}
