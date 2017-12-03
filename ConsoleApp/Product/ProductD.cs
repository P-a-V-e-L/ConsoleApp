using System;

namespace ConsoleApp
{
    public class ProductD : Product
    {
        public ProductD(decimal price, int id, string name)
        {
            Price = Math.Abs(price);
            Id = id;
            Name = name;
            Type = ProductType.ProductD;
        }
    }
}