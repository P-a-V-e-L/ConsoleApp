using System.Collections.Generic;

namespace ConsoleApp
{
    public class DiscountManager
    {
        private readonly List<DiscountProduct> _discounts = new List<DiscountProduct>();

        public void Add(DiscountProduct discount)
        {
            _discounts.Add(discount);
        }

        public List<DiscountProduct> GetDiscounts()
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
