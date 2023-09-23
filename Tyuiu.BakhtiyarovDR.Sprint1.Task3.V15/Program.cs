using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.BakhtiyarovDR.Sprint1.Task3.V15.Lib;

// ЗАДАНИЕ
// Написать программу, которая запрашивает у пользователя исходные данные,
// выполняет указанные расчеты и печатает результат на экране.
// Расчеты: Написать программу, решающую следующую задачу: 
// два автомобиля имеют скорости V1 км/ч и V2 км/ч соответственно, находятся на расстоянии S км друг от друга и 
// движутся в противоположные стороны. Определить расстояние между ними через T часов.

namespace Tyuiu.BakhtiyarovDR.Sprint1.Task3.V15
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнил: Бахтияров Д. Р. | АСОиУб-23-3";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Базовые навыки работы в C#                                        *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #15                                                             *");
            Console.WriteLine("* Выполнил: Бахтияров Динар Русланович | АСОиУб-23-3                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Условие: Написать программу, которая запрашивает у пользователя         *");
            Console.WriteLine("* исходные данные, выполняет указанные расчёты и                          *");
            Console.WriteLine("* печатает результат на экране.                                           *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Исходные данные:                                                        *");
            Console.WriteLine("***************************************************************************");

            double v1 = 60;
            double v2 = 50;
            double s = 10;
            double t = 3;

            Console.WriteLine("Скорость первого автомобиля = " + v1 + " км/ч");
            Console.WriteLine("Скорость второго автомобиля = " + v2 + " км/ч");
            Console.WriteLine("Расстояние между автомобилями = " + s + " км");
            Console.WriteLine("Время затраченное на движение = " + t + " ч");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Результат:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Расстояние между автомобилями через " + t + " часов = " + ds.DistanceOverTime(v1, v2, s, t) + " км");

            Console.ReadKey();
        }
    }
}
