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
            string filename = Console.ReadLine();
            Console.WriteLine("Введите имя для нового файла:");
            string Newfilename = Console.ReadLine();
            myMatrix.ReadMatrix(filename);
            double[,] Array = new double[0, 0];
            Array = myMatrix.ReadMatrix(filename);
            double[,] NewArray = new double[Array.GetLength(1), Array.GetLength(0)];
            for (int i = 0; i < Array.GetLength(1); i++)
                for (int j = 0; j < Array.GetLength(0); j++)
                {
                    NewArray[i, j] = Array[j, i];
                }
            myMatrix.CreateFile(NewArray, Newfilename, NewArray.GetLength(0));
            Console.ReadKey();

        }
    }
}
