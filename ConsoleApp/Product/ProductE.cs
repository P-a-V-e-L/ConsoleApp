using System;

namespace ConsoleApp
{
    public class ProductE : Product
    {
        public ProductE(decimal price, int id, string name)
        {
            Price = Math.Abs(price);
            Id = id;
            Name = name;
            Type = ProductType.ProductE;
        }
    }
}