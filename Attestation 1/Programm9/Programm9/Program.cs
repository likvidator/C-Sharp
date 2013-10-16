using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programm9
{
    class Program
    {
        /// <summary>
        /// 4.	Дано натуральное число n и вещественная матрица размера n на n. Найти среднее арифметическое:
        ///a)  каждого из столбцов;
        ///b)  каждого из столбцов, имеющих четные номера.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int a = Input("Введите размер квадратной матрицы");
            double[,] arr = new double[a, a];
            Random ran = new Random();
            for (int i = 0; i != a; i++)
                for (int j = 0; j != a; j++)
                    arr[i, j] = ran.Next(0, 100);

            double[] z = new double[a];
            double[] x = new double[a];
            z = stolb(arr,a);
            x = stolbChet(arr, a);
            PrintMatrix(arr,a);
            for (int i = 0; i != a; i++)
                Console.Write(" {0}\n",z[i]);
            for (int i = 0; i != a; i++)
            {
                if (x[i]!=0)
                 Console.Write("Chet {0}\n", x[i]);
            }
            Console.ReadKey();

        }

        private static double[] stolbChet(double[,] arr, int a)
        {
            {
                double[] z = new double[a];
                double s = 0;
                for (int i = 0; i < a-1; i+=2)
                {
                    for (int j = 0; j != a; j++)
                    {
                        s += arr[i, j];
                    }
                    z[i] = s / a;                    
                }
                return z;
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
        private static double[] stolb(double[,] arr, int a)
        {
            double[] z = new double[a];
            double s = 0;
            for (int i = 0; i != a; i++)
            {
                for (int j = 0; j != a; j++)
                {
                    s += arr[i, j];
                }
                z[i] = s / a;
            }
            return z;
        }
        private static void PrintMatrix(double[,] arr, int a)
        {
            for (int i = 0; i != a; i++)
            {
                Console.Write("\n");
                for (int j = 0; j != a; j++)
                    Console.Write("{0}[{1}{2}]\t", arr[i, j], i, j);
            }
            Console.Write("\n");
        }



    }
}
