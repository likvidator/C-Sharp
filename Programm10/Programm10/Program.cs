using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programm10
{
    class Program
    {
        /// <summary>
        /// 4.	Даны три множества Х1, Х2, Х3, содержащие целые числа из диапазона 100...200. Известно, что мощность каждого из этих множеств равна 10. 
        ///Сформировать новое множество Y=(Х1+Х2)*(Х1+Х3). На печать вывести множества Х1, Х2, Х3 и Y.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {

            double[] x1 = new double[10];
            double[] x2 = new double[10];
            double[] x3 = new double[10];
            double[] y = new double[10];
            List<double> sum1 = new List<double>();
            List<double> sum2 = new List<double>();
            x1 = Rand(x1);
            x2 = Rand(x2);
            x3 = Rand(x3);
            sum1 = Summa(x1,x2);
            for (int i = 0; i < x1.Length; i++)
                Console.Write("\t[1]{0}", x1[i]);
            Console.Write("\n");
            for (int i = 0; i < x2.Length; i++)
                Console.Write("\t[2]{0}", x2[i]);
            Console.Write("\n");
            for (int i = 0; i < sum1.Count; i++)
                Console.Write("\t[3]{0}", sum1[i]);
            Console.Write("\n");
            Console.ReadKey();

        }

        private static List<double> Summa(double[] x1, double[] x2)
        {
            List<double> sum = new List<double>();
            for (int i = 0; i < 10; i++)
            {
                sum.Add(x1[i]);
                sum.Add(x2[i]);
            }
            for (int i = 0; i < sum.Count; i++)
                for (int j = 0; j < sum.Count; j++)
                {
                    if (sum[i] == sum[j])
                    {
                        sum.Remove(i);
                    }
                }
            return sum;
        }
        private static double[] Rand(double[] x1)
        {
            Random R = new Random();
           
            for (int i = 0; i < x1.Length; i++)
            {
                x1[i] = R.Next();

            }
            return x1;
        }

    }
}
