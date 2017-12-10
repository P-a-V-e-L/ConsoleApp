using System;
using System.Collections.Generic;

namespace ConsoleApp
{
    /// <summary>
    /// Скидка на оставщиеся продукты покупателя, если у покупателя день рождения в день покупки
    /// </summary>
    internal class CalculatorProductBirthday : ICalculatorProductStrategy
    {
        public decimal GetSum(IDiscountProduct discount, List<IProduct> products)
        {
            var denyProductTypes = discount.GetDenyProductTypes();
            List<IProduct> discountProducts = new List<IProduct>();
            decimal sum = 0;
            var thisDay = DateTime.Today;
            foreach (var product in products)
            {
                if (discount.GetBirthdayOfBuyer() == thisDay && (!denyProductTypes.Contains(product.Type) && !product.IsCalculate))
                {
                    sum += product.Price;
                    discountProducts.Add(product);
                }
            }

            foreach (var product in discountProducts)
                product.IsCalculate = true;

            return sum * (1 - discount.GetDiscount() / 100);

        }
    }
}