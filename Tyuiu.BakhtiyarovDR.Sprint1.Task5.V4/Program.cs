using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.BakhtiyarovDR.Sprint1.Task5.V4.Lib;

namespace Tyuiu.BakhtiyarovDR.Sprint1.Task5.V4
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнил: Бахтияров Д. Р. | АСОиУб-23-3";
            Console.WriteLine("---------------------------------------------------------------------------");
            Console.WriteLine("- Спринт #1                                                               -");
            Console.WriteLine("- Тема: Преобразование типов и класс Convert                              -");
            Console.WriteLine("- Задание #5                                                              -");
            Console.WriteLine("- Вариант #2                                                              -");
            Console.WriteLine("- Выполнил: Бахтияров Динар Русланович | АСОиУб-23-3                      -");
            Console.WriteLine("---------------------------------------------------------------------------");
            Console.WriteLine("- Условие: Написать программу, которая запрашивает у пользователя         -");
            Console.WriteLine("- исходные данные, выполняет указанные расчёты и                          -");
            Console.WriteLine("- печатает результат на экране.                                           -");
            Console.WriteLine("---------------------------------------------------------------------------");
            Console.WriteLine("- Исходные данные:                                                        -");
            Console.WriteLine("---------------------------------------------------------------------------");
            int time;
            Console.WriteLine("Введите количество секунд:                                                 ");
            time = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("---------------------------------------------------------------------------");
            Console.WriteLine("- Результат:                                                              -");
            Console.WriteLine("---------------------------------------------------------------------------");

            Console.WriteLine("Количество полных часов = " + ds.SecondsToHours(time));

            Console.ReadKey();
        }
    }
}
