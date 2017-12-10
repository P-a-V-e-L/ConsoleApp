using System.Collections.Generic;

namespace ConsoleApp
{
    public class CalculatorProductContext
    {
        /// <summary>
        /// Стратегия расчета цены
        /// </summary>
        private readonly ICalculatorProductStrategy _strategy;

        public CalculatorProductContext(ICalculatorProductStrategy strategy)
        {
            _strategy = strategy;
        }

        public decimal GetSum(IDiscountProduct discount, List<IProduct> products)
        {
            return _strategy.GetSum(discount, products);
        }
    }
}