using System;
using System.Globalization;

namespace SalaryEmployee
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            Console.Write("Name: ");
            employee.Name = Console.ReadLine();
            Console.Write("Gross Salary: ");
            employee.GrossSalary= double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Taxes: ");
            employee.Taxes = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine();
            Console.WriteLine("Employee: " + employee);
            Console.WriteLine();
            Console.Write("What percentage do you want to increase your salary ? ");
            double porcent = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            employee.IncreaseSalary(porcent);
            Console.WriteLine();
            Console.WriteLine("Data update: " + employee);
        }
    }
}
