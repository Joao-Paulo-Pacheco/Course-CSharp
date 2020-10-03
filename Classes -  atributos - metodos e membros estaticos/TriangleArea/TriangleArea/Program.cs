using System;
using System.Globalization;

namespace TriangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangle x, y;
            x = new Triangle();
            y = new Triangle();
            Console.WriteLine("Enter the triangle measurements X: ");
            x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Enter the triangle measurements Y:");
            y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double areaX = x.Area();
            double areaY = y.Area();
            Console.WriteLine("Area of X = " + areaX.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("Area of Y = " + areaY.ToString("F4", CultureInfo.InvariantCulture));
            if (areaX > areaY)
            {
                Console.WriteLine("Bigger area: X");
            }
            else
            {
                Console.WriteLine("Bigger area: Y");
            }
        }
    }
}
