using System.Collections.Generic;

namespace ConsoleApp
{
    public interface ICalculatorProductStrategy
    {
        decimal GetSum(IDiscountProduct discount, List<IProduct> products);
    }
}