using System;

namespace ConsoleApp
{
    public class ProductH : Product
    {
        public ProductH(decimal price, int id, string name)
        {
            Price = Math.Abs(price);
            Id = id;
            Name = name;
            Type = ProductType.ProductH;
        }
    }
}