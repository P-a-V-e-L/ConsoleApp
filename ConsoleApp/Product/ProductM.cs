using System;

namespace ConsoleApp
{
    public class ProductM : Product
    {
        public ProductM(decimal price, int id, string name)
        {
            Price = Math.Abs(price);
            Id = id;
            Name = name;
            Type = ProductType.ProductM;
        }
    }
}