using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.VolovikovMV.Sprint4.Task6.V6.Lib;

namespace Tyuiu.VolovikovMV.Sprint4.Task6.V6
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #4 | Выполнил: Воловиков М. В. | АСОиУБ-23-3";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Класс Array                                                       *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #6                                                              *");
            Console.WriteLine("* Выполнил: Воловиков Михаил Васильевич | АСОиУБ-23-3                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан строковый массив данных, используя класс Array, выведите элементы   *");
            Console.WriteLine("* массива, длина которых равна 5 символам.                                *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            string[] name = { "Борис", "Анна", "Михаил", "Ирина", "Сергей", "Татьяна", "Олег" };

            Console.WriteLine("Исходный массив:");

            for (int i = 0; i < name.Length; i++)
            {
                Console.Write($"{name[i]} ");
            }

            Console.WriteLine();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Элементы массива, длина которых равна 5 символов: ");

            string[] res = ds.Calculate(name);

            for (int i = 0; i < res.Length; i++)
            {
                Console.WriteLine(res[i]);
            }
            Console.ReadKey();
        }
    }
}
