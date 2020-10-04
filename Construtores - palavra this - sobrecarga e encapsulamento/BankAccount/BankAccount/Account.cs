using System;
using System.Globalization;

namespace BankAccount
{
    class Account
    {
        public int Number { get; private set; }
        public string Holder { get; set; }
        public double Balance { get; private set; }

        public Account (int number, string holder)
        {
            Number = number;
            Holder = holder;
        }

        public Account(int number, string holder, double balance) : this(number, holder)
        {
            Balance = balance;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }

        public void Withdraw(double amount)
        {
            Balance-= amount + 5.0;
        }

        public override string ToString()
        {
            return "Conta "
                + Number
                + ", Titular: "
                + Holder
                + ", Saldo: $ "
                + Balance.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
