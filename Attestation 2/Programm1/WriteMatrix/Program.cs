using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenerateMatrixFile
{
    class Program
    {
        static void CreateFile(double[,] M, string fileName,int len)
        {
            using (BinaryWriter writer = new BinaryWriter(File.Open(fileName, FileMode.Create)))
            {
                double dlen = System.Convert.ToDouble(len);
                writer.Write(dlen);
                for (int i = 0; i < M.GetLength(0); i++)
                {
                    for (int j = 0; j < M.GetLength(1); j++)
                    {
                        writer.Write(M[i, j]);
                    }
                }

                writer.Close();
            }

        }

        private static int InputInt(string x)
        {
            Console.Write("Вводите число {0} = ", x);
            int a;
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out a))
                    if ((a >= -10) && (a <= 10))
                        return a;
                Console.Write("Ошибка! Введите целое число {0} = ", x);
            }
        }

        static void Main(string[] args)
        {
            int n = InputInt("n");
            int m = InputInt("m");
            double[,] M = new double[n, m];
            int j=0;
            for (int i = 0; i < n; i++)
            {
                for (j = 0; j < m; j++)
                {
                    Console.Write("a[{0}, {1}] =", i, j);
                    M[i, j] = double.Parse(Console.ReadLine());
                }
            }

            Console.Write("Input file name: ");
            string fileName = Console.ReadLine();
            CreateFile(M, fileName,j);
        }
    }
}
