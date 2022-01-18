using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите радиус");
            double r = Convert.ToDouble(Console.ReadLine());
            Func<double, double> CF = CircleLength;
            Console.WriteLine($"Длина окружности радиусом {r} равна {CF?.Invoke(r)}");
            Console.WriteLine();
            CF = AreaCircle;
            Console.WriteLine($"Площадь круга радиусом {r} равна {CF?.Invoke(r)}");
            Console.WriteLine();
            CF = VolumeBall;
            Console.WriteLine($"Объем шара радиусом {r} равен {CF?.Invoke(r)}");
            Console.ReadKey();
        }
        public static double CircleLength(double r)
        {
            double d = 2 * Math.PI * r;
            return d;
        }
        public static double AreaCircle(double r)
        {
            double s = Math.PI * r * r;
            return s;
        }
        public static double VolumeBall(double r)
        {
            double v = 1.3333333333333 * Math.PI * r * r * r;
            return v;
        }

    }
}
