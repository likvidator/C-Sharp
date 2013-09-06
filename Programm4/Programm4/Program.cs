using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programm4
  
    
{
    class Program
        
       
    {
        /// <summary>
        /// 5.	Вычислить y=sin1+sin1.1+sin1.2+...+sin2
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            double s=0;
            double a = 1;
            while (a <= 2) 
            {
                s = s + Math.Sin(a);
                a=a+0.1;
                
            }
            Console.Write("Ответ:{0}", s);
            Console.ReadKey();
        }

    }
}
