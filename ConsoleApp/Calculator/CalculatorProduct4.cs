using System.Collections.Generic;

namespace ConsoleApp
{
    internal class CalculatorProduct4 : ICalculatorProductStrategy
    {
        private const int COUNT = 4;

        public decimal GetSum(IDiscountProduct discount, List<IProduct> products)
        {
            var denyProductTypes = discount.GetDenyProductTypes();
            decimal sum = 0;
            List<IProduct> discountProducts = new List<IProduct>();

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