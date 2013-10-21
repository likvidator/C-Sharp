using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO; 

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
            FileInfo f = new FileInfo("1.mtx");
            FileStream fs = f.OpenWrite(); 
           // BinaryReader br = new BinaryReader(fs); 
            fs.WriteByte(1);
            
        }
        //Пыщ пыщ я бэтмен
    }
}
