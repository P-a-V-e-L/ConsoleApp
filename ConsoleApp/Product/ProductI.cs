using System;

namespace ConsoleApp
{
    public class ProductI : Product
    {
        public ProductI(decimal price, int id, string name)
        {
            Price = Math.Abs(price);
            Id = id;
            Name = name;
            Type = ProductType.ProductI;
        }
    }
}