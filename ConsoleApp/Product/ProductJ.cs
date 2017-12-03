using System;

namespace ConsoleApp
{
    public class ProductJ : Product
    {
        public ProductJ(decimal price, int id, string name)
        {
            Price = Math.Abs(price);
            Id = id;
            Name = name;
            Type = ProductType.ProductJ;
        }
    }
}