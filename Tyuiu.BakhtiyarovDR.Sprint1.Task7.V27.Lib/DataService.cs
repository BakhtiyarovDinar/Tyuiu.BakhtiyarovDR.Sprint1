using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint1;

//     cos x'2 + sin y'2     xy-12
// z = -----------------  -  ---------
//     sin y + 1             15 + cosx
namespace Tyuiu.BakhtiyarovDR.Sprint1.Task7.V27.Lib
{
    public class DataService : ISprint1Task7V27
    {
        public double Calculate(double x, double y)
        {
            double a, b, c, d;
            a = Math.Cos(x * x) + Math.Sin(y * y);
            b = Math.Sin(y - 1);
            c = (x * y - 12);
            d = (15 + Math.Cos(x));
            double res = Math.Round((a / b) - (c / b), 3);
            return res;

        }
    }
}
