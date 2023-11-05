using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.VolovikovMV.Sprint4.Task0.V15.Lib;

namespace Tyuiu.VolovikovMV.Sprint4.Task0.V15
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            int x = 1;

            Console.Title = "Спринт #4 | Выполнила: Воловиков М.В. | АСОиУб-23-3";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Одномерные массивы.(статический ввод)                             *");
            Console.WriteLine("* Задание #0                                                              *");
            Console.WriteLine("* Вариант #15                                                             *");
            Console.WriteLine("* Выполнила: Воловиков Михаил Васильевич | АСОиУб-23-3                    *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Условие:                                                                *");
            Console.WriteLine("* Дан одномерный целочисленный массив на 10 элементов заполненный         *");
            Console.WriteLine("* статическими значениями в диапазоне от 0 до 9 подсчитать произведение   *");
            Console.WriteLine("* нечетных элементов массива.                                             *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Исходные данные:                                                        *");
            Console.WriteLine("***************************************************************************");

            int[] array = { 9, 8, 7, 6, 5, 7, 3, 2, 7, 3 };

            Console.WriteLine(" Исходный массив: ");
            for (int i = 0; i <= array.Length - 1; i++)
            {
                Console.WriteLine(array[i]);
            }


            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Результат:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Произведение нечётных элементов массива: ");

            x = ds.GetMultOddArrEl(array);

            Console.WriteLine(x);

            Console.ReadKey();
        }
    }
}
