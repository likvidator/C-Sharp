using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        /// <summary>
        /// 4.	Вводится 10 произвольных имен. Необходимо распечатать их в алфавитном порядке.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            List<string> a = new List<string>();
            a = Input();
            a.Sort();
            Console.WriteLine("Ответ:");
            foreach (string x in a)
            {
                Console.WriteLine(x);
               

            }
            Console.ReadKey();
        }
        private static List<string> Input()
        {
            List<string> spis = new List<string>();
            int i = 0;
            while (i < 10)
            {
                string a = Console.ReadLine();
                spis.Add(a);
                i++;
            }
            return spis;
        }
    }
}
