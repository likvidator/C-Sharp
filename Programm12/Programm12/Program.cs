using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Programm12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("1)Name1.txt+Name2.txt\n2)Name2.txt+Name1.txt\nВыберите пункт:");
            string a = (Console.ReadLine());
            StreamWriter Name1 = new StreamWriter("Fin.txt");
            string[] file1 = System.IO.File.ReadAllLines("1.txt");
            string[] file2 = System.IO.File.ReadAllLines("2.txt");
            switch (a)
            {
                case "1":

                    for (int i = 0; i < file1.Length; i++)
                        Name1.WriteLine(file1[i]);
                    for (int i = 0; i < file2.Length; i++)
                        Name1.WriteLine(file2[i]);
                    Name1.Close();
                    break;


                case "2":

                    for (int i = 0; i < file2.Length; i++)
                        Name1.WriteLine(file2[i]);
                    for (int i = 0; i < file1.Length; i++)
                        Name1.WriteLine(file1[i]);
                    Name1.Close();
                    break;
                default:
                    Console.Write("Error");
                    break;
            }

        }
    }
}
