using System;
using System.Collections.Generic;

namespace ConsoleApp
{
    /// <summary>
    /// Множестово скидок
    /// </summary>
    public class DiscountProduct
    {
        private List<ProductType> _allowProductTypes = new List<ProductType>();
        private List<ProductType> _denyProductTypes = new List<ProductType>();
        private decimal _discount;
        private DiscountProductType _type;

        public void SetAllowProductTypes(ProductType pt1, ProductType pt2)
        {
            Check();
            _allowProductTypes = new List<ProductType>() {pt1, pt2};
            _type = DiscountProductType.ProductSet2;
        }

        public void SetAllowProductTypes(ProductType pt1, ProductType pt2, ProductType pt3)
        {
            Check();
            _allowProductTypes = new List<ProductType>() {pt1, pt2, pt3};
            _type = DiscountProductType.ProductSet3;
        }

        public void SetAllowProductTypes(ProductType pt1, ProductType pt2, ProductType pt3, ProductType pt4)
        {
            Check();
            _allowProductTypes = new List<ProductType>() {pt1, pt2, pt3, pt4};
            _type = DiscountProductType.ProductSet4;
        }

        public void SetAllowProductTypes(ProductType pt1, ProductType pt2, ProductType pt3, ProductType pt4, ProductType pt5)
        {
            Check();
            _allowProductTypes = new List<ProductType>() {pt1, pt2, pt3, pt4, pt5};
            _type = DiscountProductType.ProductSet5;
        }

        public void SetDenyProductType(ProductType pt1)
        {
            _denyProductTypes = new List<ProductType>() { pt1 };
        }

        public void SetDenyProductTypes(ProductType pt1, ProductType pt2)
        {
            _denyProductTypes = new List<ProductType>() { pt1, pt2 };
        }

        public void SetDiscountProductType(DiscountProductType type)
        {
            _type = type;
        }

        public void SetDiscount(int discount)
        {
            discount = Math.Abs(discount);
            if (discount > 100 || discount == 0)
            {
                throw new Exception("Invalid discount value (0; 100]");
            }
            _discount = discount;
        }

        public decimal GetDiscount()
        {
            return _discount;
        }

        public List<ProductType> GetAllowProductTypes()
        {
            return _allowProductTypes;
        }

        public List<ProductType> GetDenyProductTypes()
        {
            return _denyProductTypes;
        }

        public DiscountProductType GetDiscountProductType()
        {
            return _type;
        }

        private void Check()
        {
            if (_allowProductTypes.Count > 0)
            {
                throw new Exception("ProductType is already set");
            }
        }
    }
}
