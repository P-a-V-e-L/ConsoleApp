using System;

namespace ConsoleApp
{
    public class ProductF : Product
    {
        public ProductF(decimal price, int id, string name)
        {
            Price = Math.Abs(price);
            Id = id;
            Name = name;
            Type = ProductType.ProductF;
        }
    }
}