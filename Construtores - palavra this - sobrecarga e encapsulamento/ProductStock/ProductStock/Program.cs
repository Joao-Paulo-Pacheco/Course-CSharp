using System;
using System.Globalization;

namespace ProductStock
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ENTER PRODUCT DATA:");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Price: ");
            double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Amount in stock: ");
            int amount = int.Parse(Console.ReadLine());
            Product p = new Product(name, price, amount);
            Console.WriteLine();
            Console.WriteLine("Data of product: " + p);
            Console.WriteLine();
            Console.Write("Enter the number of products to be added to the stock: ");
            int qte = int.Parse(Console.ReadLine());
            p.AddProduct(qte);
            Console.WriteLine();
            Console.WriteLine("Data update: " + p);
            Console.WriteLine();
            Console.Write("Enter the number of products to be removed to the stock:  ");
            qte = int.Parse(Console.ReadLine());
            p.RemoveProduct(qte);
            Console.WriteLine();
            Console.WriteLine("Data update: " + p);
        }
    }
}
