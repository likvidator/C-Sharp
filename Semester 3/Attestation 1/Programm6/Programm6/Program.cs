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
            List<string> b = new List<string>();
            b = Sorti(a);
            Console.WriteLine("Ответ:");
            foreach (string x in a)
            {
                Console.WriteLine(x);
            }
            
            Console.ReadKey();
        }

        private static List<string> Sorti(List<string> a)
        {
            int i,c;
            for (c=0;c!=a.Count-1;c++)
            {
                for (i = 0; i != a.Count - 1; i++)
                {
                    if (inf(a[i],a[i+1]))
                    {
                        string b;
                        b = a[i];
                        a[i] = a[i+1];
                        a[i+1] = b;

                    }
  
                }
            }
            
            return a;
        }

        private static bool inf(string p1, string p2)
        {
            int i;
            for (i = 0; i < (p1.Length > p2.Length ? p2.Length : p1.Length); i++)
            {
                if ((p1.ToCharArray()[i]) < (p2.ToCharArray()[i]))
                    return false;
                if ((p1.ToCharArray()[i]) > (p2.ToCharArray()[i]))
                    return true;
            }
            return false;
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
