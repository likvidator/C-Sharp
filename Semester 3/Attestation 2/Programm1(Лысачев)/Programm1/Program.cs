using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using ReadMatrix;

namespace Programm1
{
    class Program
    {
        /// <summary>
        /// 34.	Дан файл вещественных чисел, содержащий элементы прямоугольной матрицы (по строкам),
        /// причем начальный элемент файла содержит количество столбцов матрицы. Создать новый файл 
        /// той же структуры, содержащий матрицу, транспонированную к исходной. 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            var myMatrix = new MyMatrix();
            Console.WriteLine("Введите имя файла с матрицей:");
            string inputfilename = Console.ReadLine();
            Console.WriteLine("Введите имя для нового файла:");
            string outputfilename = Console.ReadLine();
            
            myMatrix.ReadMatrix(inputfilename);
            myMatrix.TransporMatrix();
            myMatrix.CreateFile(outputfilename);
            Console.Write("Транспонирование выполнено.");
            Console.ReadKey();
        }
    }
}
