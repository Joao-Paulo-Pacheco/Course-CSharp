using System;
using System.Globalization;

namespace BankAccount
{
    class Program
    {
        static void Main(string[] args)
        {
            Account account;

            Console.Write("Enter the number of Account: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Enther the holder: ");
            string holder = Console.ReadLine();
            Console.Write("There will be initial deposit(y/n)? ");
            char resp = char.Parse(Console.ReadLine());
            if (resp == 'y' || resp == 'Y')
            {
                Console.Write("Enter the initial deposit amount: ");
                double deposit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                account = new Account(number, holder, deposit);
            }
            else
            {
                account = new Account(number, holder);
            }

            Console.WriteLine();
            Console.WriteLine("Account data:");
            Console.WriteLine(account);

            Console.WriteLine();
            Console.Write("Enter a deposit amount: ");
            double amount = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            account.Deposit(amount);
            Console.WriteLine("Data account update:");
            Console.WriteLine(account);

            Console.WriteLine();
            Console.Write("Enter a withdraw amount: ");
            amount = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            account.Withdraw(amount);
            Console.WriteLine("Data account update:");
            Console.WriteLine(account);
        }
    }
}
