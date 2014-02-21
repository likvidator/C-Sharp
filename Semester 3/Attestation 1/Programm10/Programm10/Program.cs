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
            HashSet<int> x1 = new HashSet<int>();
            HashSet<int> x2 = new HashSet<int>();
            HashSet<int> x3 = new HashSet<int>();
            HashSet<int> sum1 = new HashSet<int>();
            HashSet<int> sum2 = new HashSet<int>();
            HashSet<int> y = new HashSet<int>();
            Input(x1);
            Input(x2);
            Input(x3);
            sum1.UnionWith(x1);
            sum2.UnionWith(x1);
            sum1.UnionWith(x2);
            sum2.UnionWith(x3);
            y.UnionWith(sum1);
            y.IntersectWith(sum2);
            Console.Write("Ответ:");
            Print(x1, "x1");
            Print(x2, "x2");
            Print(x3, "x3");
            Print(y, "y");
            Console.ReadKey();
        }

        private static void Print(HashSet<int> sum1, string p)
        {
            {
                Console.Write("Множество  {0}:", p);
                foreach (int x in sum1)
                    Console.Write("  {0}", x);
                Console.Write("\n");
            }
        }




        private static void Input(HashSet<int> x1)
        {
            int a;
            Console.Write("Введите множество");
            for (int i = 0; i < 10; i++)
            {
                if (int.TryParse(Console.ReadLine(), out a))
                    x1.Add(a);
            }
        }

        /*  
         */
    }
}
