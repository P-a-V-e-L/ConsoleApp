using System;
using System.Collections.Generic;

namespace ConsoleApp
{
    /// <summary>
    /// Для расчета общей цены товаров
    /// </summary>
    public class CalculatorManager
    {
        private DiscountManager _discountManager;
        private Cart _cart;
        private decimal _sum;

        public void SetDiscountManager(DiscountManager discountManager)
        {
            _discountManager = discountManager;
        }

        public void SetCart(Cart cart)
        {
            _cart = cart;
        }

        public decimal Calculate()
        {
            if (_discountManager == null || _cart == null)
            {
                throw new Exception("Cart and DiscountManager must be set");
            }
            if (_discountManager.GetDiscounts().Count > 0)
            {
                var products = _cart.GetProducts();
                foreach (var discount in _discountManager.GetDiscounts())
                {

                    switch (discount.GetDiscountProductType())
                    {
                        case DiscountProductType.ProductSet2:
                            var calculatorProduct2Context = new CalculatorProductContext(new CalculatorProduct2());
                            _sum += calculatorProduct2Context.GetSum(discount, products);
                            break;
                        case DiscountProductType.ProductSet3:
                            var calculatorProduct3Context = new CalculatorProductContext(new CalculatorProduct3());
                            _sum += calculatorProduct3Context.GetSum(discount, products);
                            break;
                        case DiscountProductType.ProductSet4:
                            var calculatorProduct4Context = new CalculatorProductContext(new CalculatorProduct4());
                            _sum += calculatorProduct4Context.GetSum(discount, products);
                            break;
                        case DiscountProductType.ProductSet5:
                            var calculatorProduct5Context = new CalculatorProductContext(new CalculatorProduct5());
                            _sum += calculatorProduct5Context.GetSum(discount, products);
                            break;
                    }
                }
            }

            foreach (var product in _cart.GetProducts())
            {
                if (!product.IsCalculate)
                {
                    _sum += product.Price;
                    product.IsCalculate = true;
                }
            }
            return _sum;
        }
    }
}