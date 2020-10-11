using System;
using System.Collections.Generic;
using System.Text;

namespace GSTCalculator
{
    public class Product
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        private const Decimal GST = 0.1M;

        public Product (string name, decimal price)
        {
            if(String.IsNullOrEmpty(name))
            {
                throw new ArgumentException("Product name is empty");
            }

            if(price <= 0)
            {
                throw new ArgumentOutOfRangeException("Product price is smaller or equals to zero");
            }

            this.Name = name;
            this.Price = price;
        }

        public decimal CalculateGST()
        {
            return this.Price * GST;
        }
    }
}
