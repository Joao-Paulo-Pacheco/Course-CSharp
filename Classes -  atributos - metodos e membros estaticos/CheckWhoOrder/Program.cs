using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckWhoOrder
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person();
            Person p2 = new Person();

            Console.WriteLine("CHECK WHO IS OLDER");
            Console.WriteLine();
            Console.Write("1º Person Name: ");
            p1.Name = Console.ReadLine();
            Console.Write("1º Person Age: ");
            p1.Age = int.Parse(Console.ReadLine());

            Console.WriteLine("CHECK WHO IS OLDER");
            Console.WriteLine();
            Console.Write("2º Person Name: ");
            p2.Name = Console.ReadLine();
            Console.Write("2º Person Age: ");
            p2.Age = int.Parse(Console.ReadLine());
            Console.WriteLine();

            if(p1.Age > p2.Age)
            {
                Console.WriteLine("Person older: "+ p1.Name);
            }
            else
            {
                Console.WriteLine("Person older: " + p2.Name);
            }
            Console.WriteLine();
            Console.WriteLine("Enter for finish");
            Console.ReadLine();
        }
    }
}
