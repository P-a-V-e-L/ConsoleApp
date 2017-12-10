using System.Collections.Generic;

namespace ConsoleApp
{
    internal class CalculatorProduct2 : ICalculatorProductStrategy
    {
        private List<ProductType> _allowProductTypes;

        public decimal GetSum(IDiscountProduct discount, List<IProduct> products)
        {
            var allowProductTypes = discount.GetAllowProductTypes();
            var denyProductTypes = discount.GetDenyProductTypes();
            List<IProduct> discountProducts = new List<IProduct>();
            _allowProductTypes = new List<ProductType>(allowProductTypes);
            decimal sum = 0;
            foreach (var product in products)
            {
                if (_allowProductTypes.Contains(product.Type) && !denyProductTypes.Contains(product.Type) && !product.IsCalculate)
                {
                    _allowProductTypes.Remove(product.Type);
                    sum += product.Price;
                    discountProducts.Add(product);
                    if (_allowProductTypes.Count == 0)
                        break;
                }
            }
            if (_allowProductTypes.Count == 0)
            {
                foreach (var product in discountProducts)
                    product.IsCalculate = true;

                return sum * (1 - discount.GetDiscount() / 100);
            }
            return 0;
        }
    }
}