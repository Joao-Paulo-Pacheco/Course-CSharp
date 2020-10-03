using System;
using System.Globalization;

namespace RectangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectagle ret = new Rectagle();
            Console.Write("Between the width and height of the rectangle: ");
            ret.Width = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            ret.Height = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("AREA = " + ret.Area().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Perimeter = " + ret.Perimeter().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("DIAGONAL = " + ret.Diagonal().ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
