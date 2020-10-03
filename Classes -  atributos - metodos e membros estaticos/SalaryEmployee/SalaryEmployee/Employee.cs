using System;
using System.Globalization;

namespace SalaryEmployee
{
    class Employee
    {
        public string Name;
        public double GrossSalary;
        public double Taxes;

        public double LiquidSalary()
        {
            return GrossSalary - Taxes;
        }

        public void IncreaseSalary(double percentage)
        {
            GrossSalary = GrossSalary + (GrossSalary* percentage / 100.0);
        }

        public override string ToString()
        {
            return Name
            + ", R$ "
            + LiquidSalary().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
