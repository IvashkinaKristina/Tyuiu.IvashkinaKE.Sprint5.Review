using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
using Tyuiu.IvashkinaKE.Sprint5.TaskReview.V20.Lib;

namespace Tyuiu.IvashkinaKE.Sprint5.TaskReview.V20
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #5 | Выполнила: Ивашкина К. Э.  | АСОиУБ-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Review                                                            *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #20                                                             *");
            Console.WriteLine("* Выполнила: Ивашкина Кристина Эдуардовна | АСОиУБ-23-1                   *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан файл в котором есть набор символьных данных.Заменить все            *");
            Console.WriteLine("* двоенные буквы 'сс' на 'с'. Полученный результат сохранить в файл       *");
            Console.WriteLine("* OutPutDataFileTask7V20.txt.                                             *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            string path = $@"C:\DataSprint5\InPutDataFileTask7V20.txt";
            string pathSaverFile = $@"{Directory.GetCurrentDirectory()}\OutPutDataFileTask7V20.txt";
            Console.WriteLine("Данные находятся в файле: " + path);


            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Находится в файле: ");
            pathSaverFile = ds.LoadDataAndSave(path);
            Console.WriteLine(pathSaverFile);
            Console.ReadKey();
        }
    }
}
