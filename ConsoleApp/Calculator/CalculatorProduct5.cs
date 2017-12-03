using System.Collections.Generic;

namespace ConsoleApp
{
    internal class CalculatorProduct5 : ICalculatorProductStrategy
    {
        private const int COUNT = 5;
        private readonly List<ProductType> _deny = new List<ProductType>() {ProductType.ProductA, ProductType.ProductC};

        public decimal GetSum(DiscountProduct discount, List<Product> products)
        {
            var denyProductTypes = discount.GetDenyProductTypes();
            decimal sum = 0;
            List<Product> discountProducts = new List<Product>();

            foreach (var product in products)
            {
                if (!denyProductTypes.Contains(product.Type) && !product.IsCalculate)
                {
                    sum += product.Price;
                    discountProducts.Add(product);
                }
            }
            if (discountProducts.Count == COUNT)
            {
                foreach (var product in discountProducts)
                    product.IsCalculate = true;

                return sum * (1 - discount.GetDiscount() / 100);
            }
            return 0;
        }
    }
}