using System;
using System.Globalization;

namespace ReportCard
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student= new Student();
            Console.Write("Name of Student: ");
            student.Name = Console.ReadLine();
            Console.WriteLine("Enter the student's three grades: ");
            student.Note1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            student.Note2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            student.Note3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("NOTE FINISH = "
            + student.NoteFinish().ToString("F2", CultureInfo.InvariantCulture));

            if (student.Acredited())
            {
                Console.WriteLine("ACREDITED");
            }
            else
            {
                Console.WriteLine("DISAPPROVED");
                Console.WriteLine("MISSED "
                + student.RemainingNote().ToString("F2", CultureInfo.InvariantCulture)
                + " NOTES");
            }
        }
    }
}
