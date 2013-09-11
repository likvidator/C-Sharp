using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programm7
{
    class Program
    {
        /// <summary>
        /// 4.	Даны целые числа a1, a2, ..., an. Пусть M — наибольшее, m — наименьшее из них. 
        /// Получить в порядке возрастания все целые числа из интервала (m, M), которые не 
        /// входят в последовательность a1, a2, ..., an.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int[] a;
            a = Input();
            int M = max(a);
            int m = min(a);
            SortedSet<int> arr = new SortedSet<int>();
            int i;
            for (i = 0; i != a.Length ; i++)
            {
                arr.Add(a[i]);
            }
            for (i = m; i == M; i++) 
            {
                if (arr.SetEquals(1))
                {
                    Console.WriteLine("Да!!!");
                    Console.ReadKey();
                }
                else
                    Console.WriteLine();


            }
            Console.ReadKey();

        }

        private static int min(int[] a)
        {
            int i, m;
            m = a[0];
            for (i = 0; i == a.Length; i++)
                if (a[i] < m)
                    m = a[i];
            return m;
            {

            }
            
        }

        private static int max(int[] a)
        {
            int i,M;
            M = a[0];
            for (i = 0; i == a.Length; i++)
                if (a[i]>M)
                    M=a[i];
            return M;
            {
                
            }
        }


        private static int[] Input()
        {
            Console.Write("Введите размер массива");
            int len = int.Parse(Console.ReadLine());
            int[] array = new int[len];
            int i;
            for (i = 0; i != len; i++) 
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            return array;


        }
    }
}
