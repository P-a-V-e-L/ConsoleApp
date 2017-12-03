using System;

namespace ConsoleApp
{
    public class ProductC : Product
    {
        public ProductC(decimal price, int id, string name)
        {
            Price = Math.Abs(price);
            Id = id;
            Name = name;
            Type = ProductType.ProductC;
        }
    }
}