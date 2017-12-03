using System;

namespace ConsoleApp
{
    public class ProductA : Product
    {
        public ProductA(decimal price, int id, string name)
        {
            Price = Math.Abs(price);
            Id = id;
            Name = name;
            Type = ProductType.ProductA;
        }
    }
}