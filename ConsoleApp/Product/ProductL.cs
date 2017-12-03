using System;

namespace ConsoleApp
{
    public class ProductL : Product
    {
        public ProductL(decimal price, int id, string name)
        {
            Price = Math.Abs(price);
            Id = id;
            Name = name;
            Type = ProductType.ProductL;
        }
    }
}