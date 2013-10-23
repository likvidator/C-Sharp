using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ReadMatrix
{
    class Program
    {
        static void Main(string[] args)
        {



            string fileName = Console.ReadLine();
            FileInfo f = new FileInfo(fileName);
            long s = f.Length;
            s = (s / 8) - 1;
            int len = System.Convert.ToInt32(s);
            double[] a = new double[len];
            if (File.Exists(fileName))
            {
                using (BinaryReader read = new BinaryReader(File.Open(fileName, FileMode.Open)))
                {
                    int stolb = System.Convert.ToInt32(read.ReadDouble());
                    for (int i = 0; i < a.Length; i++)
                    {
                        a[i] = read.ReadDouble();
                    }
                    int k = 0;
                    double[,] array = new double[stolb, (s / stolb)];
                    for (int i = 0; i < stolb; i++)
                        for (int j = 0; j < (s / stolb); j++)
                        {
                            array[i, j] = a[k];
                            k++;
                        }
                    for (int i = 0; i < stolb; i++)
                    {
                        for (int j = 0; j < (s / stolb); j++)
                        {
                            Console.Write(array[i, j] + " ");
                        }
                        Console.Write("\n");
                    }
                }

                for (int i = 0; i < a.Length; i++)
                {
                    Console.Write(a[i] + " ");
                }
                Console.ReadKey();
            }
        }
    }
}
