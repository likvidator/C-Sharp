using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ReadMatrix
{
    public class MyMatrix
    {
        public  double[,] ReadMatrix(string fileName)
        {
            double[,] ArrayEmpty = new double[0, 0];
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
                    return array;
                }
            }
            return ArrayEmpty;
        }
        public void CreateFile(double[,] M, string fileName, int len)
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
    }
}

