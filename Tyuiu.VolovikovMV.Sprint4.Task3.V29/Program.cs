using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.VolovikovMV.Sprint4.Task3.V29.Lib;

namespace Tyuiu.VolovikovMV.Sprint4.Task3.V29
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            int[,] mtrx = new int[5, 5] { {9, 9, 8, 6, 9 },

                                         { 5, 8, 8, 8, 7 },

                                         { 6, 5, 9, 7, 9 },

                                         { 7, 7, 9, 7, 8 },

                                         { 8, 5, 8, 5, 5 } };
            int rows = mtrx.GetUpperBound(0) + 1;
            int columns = mtrx.Length / rows;

            Console.Title = "Спринт #4 | Выполнила: Воловиков М.В. | АСОиУб-23-3";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Одномерные массивы.(генератор случайных чисел)                    *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #29                                                             *");
            Console.WriteLine("* Выполнила: Воловиков Михаил Васильевич | АСОиУб-23-3                    *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Условие:                                                                *");
            Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов заполненный         *");
            Console.WriteLine("* статическими значениями в диапазоне от 5 до 9. Найдите произведение     *");
            Console.WriteLine("* элементов в первом столбце массива.                                     *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Исходные данные:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Исходный массив:");

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"{mtrx[i,j]} \t");
                }
            }

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine($"Произведение элементов в первом столбце массива.: {ds.Calculate(mtrx)}");

            Console.ReadKey();
        }
    }
}
