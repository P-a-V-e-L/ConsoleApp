using System;

namespace ConsoleApp
{
    public class ProductG : Product
    {
        public ProductG(decimal price, int id, string name)
        {
            Price = Math.Abs(price);
            Id = id;
            Name = name;
            Type = ProductType.ProductG;
        }
    }
}