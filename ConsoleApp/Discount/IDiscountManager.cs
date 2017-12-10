using System.Collections.Generic;

namespace ConsoleApp
{
    public interface IDiscountManager
    {
        void Add(IDiscountProduct discount);
        List<IDiscountProduct> GetDiscounts();
        void RemoveDiscountByIndex(int index);
    }
}