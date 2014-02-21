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
        double[,] Array;

        public void ReadMatrix(string fileName)
        {
            FileInfo f = new FileInfo(fileName);
            long s = f.Length;
            s = (s / 8) - 1;
            int len = System.Convert.ToInt32(s);
            double[] a = new double[len];
            int stolb = 0;
            if (File.Exists(fileName))
            {
                using (BinaryReader read = new BinaryReader(File.Open(fileName, FileMode.Open)))
                {
                    stolb = System.Convert.ToInt32(read.ReadDouble());
                    for (int i = 0; i < a.Length; i++)
                    {
                        a[i] = read.ReadDouble();
                    }
                }
                int k = 0;
                Array = new double[stolb, (s / stolb)];
                for (int i = 0; i < stolb; i++)
                    for (int j = 0; j < (s / stolb); j++)
                    {
                        Array[i, j] = a[k];
                        k++;
                    }

            }
        }
        public void CreateFile(string fileName)
        {
            int len = Array.GetLength(0);
            using (BinaryWriter writer = new BinaryWriter(File.Open(fileName, FileMode.Create)))
            {
                double dlen = System.Convert.ToDouble(len);
                writer.Write(dlen);
                for (int i = 0; i < Array.GetLength(0); i++)
                {
                    for (int j = 0; j < Array.GetLength(1); j++)
                    {
                        writer.Write(Array[i, j]);
                    }
                }

                writer.Close();
            }

        }
        public void TransporMatrix()
        {
            var myMatrix = new MyMatrix();
            double[,] NewArray = new double[Array.GetLength(1), Array.GetLength(0)];
            for (int i = 0; i < Array.GetLength(1); i++)
                for (int j = 0; j < Array.GetLength(0); j++)
                {
                    NewArray[i, j] = Array[j, i];
                }
            Array = NewArray;
        }
    }
}

