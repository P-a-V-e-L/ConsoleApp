using System.Collections.Generic;

namespace ConsoleApp
{
    public class DiscountManager : IDiscountManager
    {
        private readonly List<IDiscountProduct> _discounts = new List<IDiscountProduct>();

        public void Add(IDiscountProduct discount)
        {
            _discounts.Add(discount);
        }

        public List<IDiscountProduct> GetDiscounts()
        {
            return _discounts;
        }

        public void RemoveDiscountByIndex(int index)
        {
            if (index >= 0 && index < _discounts.Count)
                _discounts.RemoveAt(index);
        }
    }
}
