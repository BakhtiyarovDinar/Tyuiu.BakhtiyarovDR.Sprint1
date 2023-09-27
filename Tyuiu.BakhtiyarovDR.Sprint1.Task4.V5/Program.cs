using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.BakhtiyarovDR.Sprint1.Task4.V5.Lib;

// Написать программу, которая запрашивает у пользователя исходные данные, 
// вычисляет результат по формуле и печатает его на экране. Ответ округлите до 3 знаков после запятой.
// Формула:
//     1
// ----------
//  |x + √y|

namespace Tyuiu.BakhtiyarovDR.Sprint1.Task4.V5
{
    class Program
    {
        static void Main(string[] args)
        {

            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнил: Бахтияров Д. Р. | АСОиУб-23-3";
            Console.WriteLine("---------------------------------------------------------------------------");
            Console.WriteLine("- Спринт #1                                                               -");
            Console.WriteLine("- Тема: Class Math                                                        -");
            Console.WriteLine("- Задание #4                                                              -");
            Console.WriteLine("- Вариант #5                                                              -");
            Console.WriteLine("- Выполнил: Бахтияров Динар Русланович | АСОиУб-23-3                      -");
            Console.WriteLine("---------------------------------------------------------------------------");
            Console.WriteLine("- Условие: Написать программу, которая запрашивает у пользователя         -");
            Console.WriteLine("- исходные данные, выполняет указанные расчёты и                          -");
            Console.WriteLine("- печатает результат на экране.                                           -");
            Console.WriteLine("---------------------------------------------------------------------------");

            Console.WriteLine("---------------------------------------------------------------------------");
            Console.WriteLine("- Введите данные:                                                         -");
            Console.WriteLine("---------------------------------------------------------------------------");

            int x, y;

            Console.WriteLine(" Введите значение X:                                                       ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" Введите значение Y:                                                       ");
            y = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine(Math.Round(ds.Calculate(x, y), 3));

            Console.ReadKey();
        }
    }
}
