using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programm5
{
    /// <summary>
    /// 4.	Вводится последовательность вещественных чисел, оканчивающаяся нулём, 
    /// и состоящая более чем из одного ненулевого элемента. Определить, 
    /// каких чисел в последовательности больше: положительных или отрицательных. 
    /// </summary>
    class Program
        
    {
        static void Main(string[] args)
        {
            List<double> a = new List<double>();
            a = Input();
            int p=0,b=0;
            foreach (int x in a)
            {
                if (x > 0)
                    p++;
                else
                    b++;
            }
            if (p > b)
            {
                Console.Write("Положительных больше чем отрицательных");
                Console.ReadKey();
            }

            else
                if (p == b)
                {
                    Console.Write("Положительных и отрицательных равное количество");
                    Console.ReadKey();
                }
                else
                {
                    Console.Write("Отрицательных больше");
                    Console.ReadKey();
                }
            
        }
        private static List<double> Input()
        {
            double a;
            List<double> array = new List<double>();
            Console.Write("Введите число ");
            while (true)
            {
                if (double.TryParse(Console.ReadLine(), out a))
                {
                    if ((a % 10 == 0) && (a != 0))
                    {
                        array.Add(a);
                        Console.Write("Введите число "); 
                    }
                    else
                        return (array);
                }
                else
                    Console.Write("Ввеите действительное число, оканчивающаяся нулём, и состоящая более чем из одного ненулевого элемента ");
            }
        }
    }
}
