using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AverageSalary
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee e1 = new Employee();
            Employee e2 = new Employee();

            Console.WriteLine("AVERAGE SALARY CALCULATION");
            Console.WriteLine();
            Console.Write("1º Employee Name: ");
            e1.Name = Console.ReadLine();
            Console.Write("1º Employee Salary: ");
            e1.Salary = double.Parse(Console.ReadLine());
            Console.WriteLine();
            
            Console.Write("2º Employee Name: ");
            e2.Name = Console.ReadLine();
            Console.Write("2º Employee Salary: ");
            e2.Salary = double.Parse(Console.ReadLine());
            Console.WriteLine();

            double average = (e1.Salary + e2.Salary) / 2;
            Console.WriteLine("AVERAGE SALARY = R$" + average);

            Console.WriteLine();
            Console.WriteLine("Pree Enter for finish");
            Console.ReadLine();
        }
    }
}
