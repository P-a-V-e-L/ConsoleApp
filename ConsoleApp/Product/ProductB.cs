using System;

namespace ConsoleApp
{
    public class ProductB : Product
    {
        public ProductB(decimal price, int id, string name)
        {
            Price = Math.Abs(price);
            Id = id;
            Name = name;
            Type = ProductType.ProductB;
        }
    }
}