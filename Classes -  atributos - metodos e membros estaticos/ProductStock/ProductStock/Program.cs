using System;
using System.Globalization;

namespace ProductStock
{
    class Program
    {
        static void Main(string[] args)
        {
            Product p = new Product();
            Console.WriteLine("Enter product data: ");
            Console.Write("Name: ");
            p.Name = Console.ReadLine();
            Console.Write("Price: ");
            p.Price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Amount in Stock: ");
            p.Amount= int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Product data: " + p);
            Console.WriteLine();
            Console.Write("Enter the number of products to be added to stock: ");
            int qte = int.Parse(Console.ReadLine());
            p.AddProduct(qte);
            Console.WriteLine();
            Console.WriteLine("Dada update: " + p);
            Console.WriteLine();
            Console.Write("Enter the number of products to be removed to stock: ");
            qte = int.Parse(Console.ReadLine());
            p.RemoverProdutos(qte);
            Console.WriteLine();

            Console.WriteLine("Data update: " + p);
        }
    }
}
