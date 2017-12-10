using System;
using System.Collections.Generic;

namespace ConsoleApp
{
    public interface IDiscountProduct
    {
        void SetAllowProductTypes(ProductType pt1, ProductType pt2);
        void SetAllowProductTypes(ProductType pt1, ProductType pt2, ProductType pt3);
        void SetAllowProductTypes(ProductType pt1, ProductType pt2, ProductType pt3, ProductType pt4);
        void SetAllowProductTypes(ProductType pt1, ProductType pt2, ProductType pt3, ProductType pt4, ProductType pt5);
        void SetDenyProductType(ProductType pt1);
        void SetDenyProductTypes(ProductType pt1, ProductType pt2);
        void SetDiscountProductType(DiscountProductType type);
        void SetDiscount(int discount);
        decimal GetDiscount();
        List<ProductType> GetAllowProductTypes();
        List<ProductType> GetDenyProductTypes();
        DiscountProductType GetDiscountProductType();
        void SetBirthdayOfBuyer(DateTime dateTime);
        DateTime GetBirthdayOfBuyer();
    }
}