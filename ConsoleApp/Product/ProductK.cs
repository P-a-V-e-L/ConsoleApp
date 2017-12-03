using System;

namespace ConsoleApp
{
    public class ProductK : Product
    {
        public ProductK(decimal price, int id, string name)
        {
            Price = Math.Abs(price);
            Id = id;
            Name = name;
            Type = ProductType.ProductK;
        }
    }
}