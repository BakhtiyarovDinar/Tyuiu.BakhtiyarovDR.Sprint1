using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.BakhtiyarovDR.Sprint1.Task6.V3.Lib;

namespace Tyuiu.BakhtiyarovDR.Sprint1.Task6.V3
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #1 | Выполнил: Бахтияров Д. Р. | АСОиУб-23-3";
            Console.WriteLine("---------------------------------------------------------------------------");
            Console.WriteLine("- Спринт #1                                                               -");
            Console.WriteLine("- Тема: Работа со строками класс String                                   -");
            Console.WriteLine("- Задание #6                                                              -");
            Console.WriteLine("- Вариант #3                                                              -");
            Console.WriteLine("- Выполнил: Бахтияров Динар Русланович | АСОиУб-23-3                      -");
            Console.WriteLine("---------------------------------------------------------------------------");
            Console.WriteLine("- Условие: Написать программу, которая запрашивает у пользователя         -");
            Console.WriteLine("- исходные данные, выполняет указанные расчёты и                          -");
            Console.WriteLine("- печатает результат на экране.                                           -");
            Console.WriteLine("---------------------------------------------------------------------------");
            Console.WriteLine("- Исходные данные:                                                        -");
            Console.WriteLine("---------------------------------------------------------------------------");
            Console.WriteLine("  Введите строку:                                                          ");
            string value = Convert.ToString(Console.ReadLine());

            Console.WriteLine("---------------------------------------------------------------------------");
            Console.WriteLine("- Результат:                                                              -");
            Console.WriteLine("---------------------------------------------------------------------------");

            Console.WriteLine("Последние литеры каждого слова: " + ds.LastLetterWord(value));

            Console.ReadKey();
        }
    }
}
