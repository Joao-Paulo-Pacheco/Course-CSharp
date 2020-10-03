using System;
using System.Collections.Generic;
using System.Globalization;

namespace ProductStock
{
    class Product
    {
        public string Name;
        public double Price;
        public int Amount;

        public double TotalValueInStock()
        {
            return Price * Amount;
        }

        public void AddProduct(int amount)
        {
            Amount += amount;
        }
        public void RemoverProdutos(int amount)
        {
            Amount -= amount;
        }

        public override string ToString()
        {
            return Name
            + ", $ "
            + Price.ToString("F2", CultureInfo.InvariantCulture)
            + ", "
            + Amount
            + " units, Total: $ "
            + TotalValueInStock().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
