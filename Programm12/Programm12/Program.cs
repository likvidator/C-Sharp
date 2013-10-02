using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Programm12
{
    /// <summary>
    /// 4.	Даны два текстовых файла с именами Name1 и Name2. 
    /// Создать новый текстовый файл с именем Name3, являющийся 
    /// объединением содержимого файлов Name1 и Name2 (в указанном порядке). 
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("1)Name1.txt+Name2.txt\n2)Name2.txt+Name1.txt\nВыберите пункт:");
            string a = (Console.ReadLine());
            StreamReader Name1 = new StreamReader("Name1.txt");
            StreamReader Name2 = new StreamReader("Name2.txt");
            StreamWriter Name3 = new StreamWriter("Name3.txt");
            switch (a)
            {
                case "1":
                    while (!Name1.EndOfStream)
                        Name3.WriteLine(Name1.ReadLine());
                    while (!Name2.EndOfStream)
                        Name3.WriteLine(Name2.ReadLine());
                    
                    break;
                case "2":
                    while (!Name2.EndOfStream)
                        Name3.WriteLine(Name2.ReadLine());
                    while (!Name1.EndOfStream)
                        Name3.WriteLine(Name1.ReadLine());
                    break;
                default:
                    Console.Write("Error");
                    break;
            }
            Name1.Close();
            Name2.Close();
            Name3.Close();
        }
    }
}
