using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.BakhtiyarovDR.Sprint1.Task2.V26.Lib;


// ЗАДАНИЕ
// Написать программу, которая запрашивает у пользователя исходныен данные,
// выполняет указанные расчеты и печатает результат на экране.


namespace Tyuiu.BakhtiyarovDR.Sprint1.Task2.V26
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнил: Бахтияров Д. Р. | АСОиУБ-23-3";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int value;

            Console.WriteLine("Введите значение (час) ");
            value = Convert.ToInt32(Console.ReadLine());

            int valueTwo;

            Console.WriteLine("Введите значение (минуты) ");
            valueTwo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine(" РЕЗУЛЬТАТ:                                                                ");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Количество минут прошло с начала суток = " + ((value * 60) + valueTwo));

            Console.ReadLine();
        }
    }
}
