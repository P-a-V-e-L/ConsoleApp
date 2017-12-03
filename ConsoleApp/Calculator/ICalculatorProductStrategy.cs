using System.Collections.Generic;

namespace ConsoleApp
{
    public interface ICalculatorProductStrategy
    {
        decimal GetSum(DiscountProduct discount, List<Product> products);
    }
}