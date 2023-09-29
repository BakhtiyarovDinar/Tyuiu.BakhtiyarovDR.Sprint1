using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.BakhtiyarovDR.Sprint1.Task7.V27.Lib;

namespace Tyuiu.BakhtiyarovDR.Sprint1.Task7.V27
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #1 | Выполнил: Бахтияров Д. Р. | АСОиУБ-23-3";
            Console.WriteLine("---------------------------------------------------------------------------");
            Console.WriteLine("- Спринт #1                                                               -");
            Console.WriteLine("- Тема: Базовые навыки работы в C#                                        -");
            Console.WriteLine("- Задание #7                                                              -");
            Console.WriteLine("- Вариант #27                                                             -");
            Console.WriteLine("- Выполнил: Бахтияров Динар Русланович | АСОиУб-23-3                      -");
            Console.WriteLine("---------------------------------------------------------------------------");
            Console.WriteLine("- УСЛОВИЕ:                                                                -");
            Console.WriteLine("- Написать программу, которая вычисляет математическое выражение по       -");
            Console.WriteLine("- исходным  значениям данных, вводимых пользователем.                     -");
            Console.WriteLine("-                                                                         -");
            Console.WriteLine("---------------------------------------------------------------------------");
            Console.WriteLine("- ИСХОДНЫЕ ДАННЫЕ:                                                        -");
            Console.WriteLine("---------------------------------------------------------------------------");
            Console.WriteLine("Введите значение X:                                                        ");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение Y:                                                        ");
            double y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("---------------------------------------------------------------------------");
            double res = ds.Calculate(x, y);
            Console.WriteLine($"РЕЗУЛЬТАТ: {res}");
            Console.ReadLine();
        }
    }
}
