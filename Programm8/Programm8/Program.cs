using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programm8
{
    class Program
    {
        /// <summary>
        /// 4.	Дана матрица размера n×m. В каждой строке1|столбце2 найти количество 
        /// элементов, больших3|меньших4 среднего арифметического всех элементов этой с
        /// троки1|столбца2
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int n, m;
            n = Input("Введите n:");
            m = Input("Введите m:");
            Random ran = new Random();
            double[,] arr = new double[n, m];
            for (int i = 0; i != n; i++)
                for (int j = 0; j != m; j++)
                    arr[i, j] = ran.Next(1, 100);
            PrintMatrix(arr, n, m);
            Console.ReadKey();



        }

        private static void PrintMatrix(double[,] arr, int n, int m)
        {
            for (int i = 0; i != n; i++)
            {
                Console.Write("\n");
                for (int j = 0; j != m; j++)
                    Console.Write("{0}\t", arr[i, j]);
            }
        }


        private static int Input(string p)
        {
            double a;
            Console.Write("Input {0}:", p);
            while (true)
            {
                if (double.TryParse(Console.ReadLine(), out a))
                {
                    return (int)a;
                }
                else
                {
                    Console.WriteLine("Введите действительное число ");
                }
            }
        }
    }
}