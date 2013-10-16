using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programm11
{
    /// <summary>
    /// 4.	Дано
    ///const
    /// MaxN = 30;
    ///type
    /// ВещТип = record
    ///             знак : boolean;
    ///             мантисса, порядок : real;
    ///           end;
    ///  список = array[1..MaxN] of ВещТип;
    ///
    ///Описать:
    ///4.1 функцию MaxNeg(C) для нахождения минимального отрицательного числа из списка чисел С;
    ///4.2 функцию MaxDi(C) для нахождения максимального порядка числа из списка вещественных чисел С;
    ///
    /// </summary>
    class Program
    {
        const int MaxN = 5;
        public double Max_Di(MPclass[] array)
        {
            double temp = array[0].P;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].P > temp)
                {
                    temp = array[i].P;
                }
            }
            return temp;
        }
        public double MaxNeg(MPclass[] array)
        {
            double temp = 0;
            for (int i = 0; i < array.Length; i++)
                if (!array[i].Zn)
                    temp = array[i].ToDouble();
            for (int i = 0; i < array.Length; i++)
            {
                if ((array[i].ToDouble() > temp)&&(!array[i].Zn))
                    temp = array[i].ToDouble();
            }
            return temp;
        }
        static void Main(string[] args)
        {
            MPclass[] arr = new MPclass[MaxN];
            arr[0] = new MPclass(2, 1, false);
            arr[1] = new MPclass(4, 1, true);
            arr[2] = new MPclass(5, 1, false);
            arr[3] = new MPclass(6, 7, true);
            arr[4] = new MPclass(7, 1, false);
            Program mc = new Program();
            double a =mc.MaxNeg(arr);
            double b = mc.Max_Di(arr);
            Console.WriteLine("Max neg ={0}",a);
            Console.WriteLine("Max Di ={0}",b);


            Console.ReadKey();
        }


    }

    public class MPclass
    {
        private double m, p;

        public double P
        {
            get { return p; }
            set { p = value; }
        }

        public double M
        {
            get { return m; }
            set { m = value; }
        }
        private bool zn;

        public bool Zn
        {
            get { return zn; }
            set { zn = value; }
        }

        public MPclass(double m, double p, bool zn)
        {
            this.m = m;
            this.p = p;
            this.zn = zn;
        }
        public double ToDouble()
        {
            double a, b;
            if (zn)
                b = 1;
            else
                b = -1;
            a = b * m * (Math.Pow(10, p));
            return a;
        }
    }
}
