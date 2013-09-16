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
            n = Input("Введите n");
            m = Input("Введите m");
            Random ran = new Random();
            double[,] arr = new double[n, m];
            for (int i = 0; i != n; i++)
                for (int j = 0; j != m; j++)
                    arr[i, j] = ran.Next(1, 100);
            double[] a = new double[n];
            double[] b = new double[m];
            a = stolb(arr, m, n);
            b = strok(arr, m, n);
            double[] sz = new double[n];
            double[] sx= new double[n];
            double[] stx = new double[m];
            double[] stz = new double[m];
            for (int i = 0; i != n; i++)
            {
                for (int j = 0; j != m; j++)
                {
                    if (arr[i, j] > a[i])
                        sz[i]++;
                    else
                        sx[i]++;
                }
            }
            for (int j = 0; j != m; j++)
            {
                for (int i = 0; i != n; i++)
                {
                    if (arr[j, i] > b[j])
                        stx[i]++;
                    else
                        stz[i]++;
                }
            }

            PrintMatrix(arr, n, m);
            Printf("Больше элементов в строке", sz);
            Printf("Меньше элементов в строке", sx);
            Printf("Больше элементов в столбце", stz);
            Printf("Меньше элементов в столбце", stx);

            Console.ReadKey();
        }

        private static void Printf(string p, double[] sz)
        {
            Console.WriteLine(p);
            for (int i = 0; i != sz.Length; i++)
                Console.Write("  {0}",sz[i]);
            Console.WriteLine("\n");
        }   

        private static double[] strok(double[,] arr, int m, int n)
        {
            double[] a = new double[m];
            double s = 0;
            for (int i = 0; i != m; i++)
            {
                for (int j = 0; j != n; j++)
                {
                    s += arr[j, i];
                }
                a[i] = s / m;
            }
            return a;
        }

        private static double[] stolb(double[,] arr, int m, int n)
        {
            double[] a = new double[n];
            double s = 0;
            for (int i = 0; i != n; i++)
            {
                for (int j = 0; j != m; j++)
                {
                    s += arr[i, j];
                }
                a[i] = s / m;
            }
            return a;
        }

        private static void PrintMatrix(double[,] arr, int n, int m)
        {
            for (int i = 0; i != n; i++)
            {
                Console.Write("\n");
                for (int j = 0; j != m; j++)
                    Console.Write("{0}[{1}{2}]\t", arr[i, j], i, j);
            }
            Console.Write("\n");
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