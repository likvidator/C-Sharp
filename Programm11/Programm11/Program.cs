using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programm11
{
    class Program
    {
        const int MaxN = 5;


        private double Max_Di(MPclass[] array)
        {
            double temp = array[0].P;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].p > temp)
                {
                    temp = array[i].P;
                }
            }
            return temp;
        }

        static void Main(string[] args)
        {
            MPclass[] arr = new MPclass[MaxN];
            for (int i = 0; i < MaxN; i++)
            {
                arr[i] = new MPclass(2, 1, false);
            }
            double l = arr[0].ToDouble();
            
            Console.Write(l);

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
        public double  ToDouble()
        {
            double a,b;
            if (zn)
                b = 1;
            else
                b = -1;
            a = b * m * (Math.Pow(10, p));
            return a;
        }

        //public override string ToString()
        //{
        //    return "!!!!!!!!!!!!!!";// zn ? "" : "-" +  m.ToString() + " " + p.ToString(); 
        //}
    }
}
