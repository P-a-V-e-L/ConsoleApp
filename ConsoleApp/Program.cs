using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var productA = Product.CreateProduct(ProductType.ProductA, 200, "A");
            var productB = Product.CreateProduct(ProductType.ProductB, 100, "B");
            var productC = Product.CreateProduct(ProductType.ProductC, 300, "C");
            var productD = Product.CreateProduct(ProductType.ProductD, 400, "D");
            var productE = Product.CreateProduct(ProductType.ProductE, 500, "E");
            var productC1 = Product.CreateProduct(ProductType.ProductC, 50, "C1");
            var productA1 = Product.CreateProduct(ProductType.ProductA, 50, "A1");
            var productC2 = Product.CreateProduct(ProductType.ProductC, 60, "C2");

            var discount1 = new DiscountProduct();
            discount1.SetAllowProductTypes(ProductType.ProductA, ProductType.ProductB);
            discount1.SetDiscount(10);

            var discount2 = new DiscountProduct();
            discount2.SetAllowProductTypes(ProductType.ProductA, ProductType.ProductK);
            discount2.SetDiscount(5);

            var discount3 = new DiscountProduct();
            discount3.SetAllowProductTypes(ProductType.ProductA, ProductType.ProductL);
            discount3.SetDiscount(5);

            var discount4 = new DiscountProduct();
            discount4.SetAllowProductTypes(ProductType.ProductA, ProductType.ProductM);
            discount4.SetDiscount(5);

            var discount5 = new DiscountProduct();
            discount5.SetAllowProductTypes(ProductType.ProductD, ProductType.ProductE);
            discount5.SetDiscount(5);

            var discount6 = new DiscountProduct();
            discount6.SetAllowProductTypes(ProductType.ProductE, ProductType.ProductF, ProductType.ProductG);
            discount6.SetDiscount(5);

            var discount7 = new DiscountProduct();
            discount7.SetDenyProductTypes(ProductType.ProductA, ProductType.ProductC);
            discount7.SetDiscountProductType(DiscountProductType.ProductSet3);
            discount7.SetDiscount(5);

            var discount8 = new DiscountProduct();
            discount8.SetDenyProductTypes(ProductType.ProductA, ProductType.ProductC);
            discount8.SetDiscountProductType(DiscountProductType.ProductSet4);
            discount8.SetDiscount(5);

            var discount9 = new DiscountProduct();
            discount9.SetDenyProductTypes(ProductType.ProductA, ProductType.ProductC);
            discount9.SetDiscountProductType(DiscountProductType.ProductSet5);
            discount9.SetDiscount(5);

            var cart = new Cart();
            cart.AddProduct(productA);
            cart.AddProduct(productB);
            cart.AddProduct(productC);
            cart.AddProduct(productD);
            cart.AddProduct(productE);
            cart.AddProduct(productC1);
            cart.AddProduct(productA1);
            cart.AddProduct(productC2);

            var discountManager = new DiscountManager();
            discountManager.Add(discount1);
            discountManager.Add(discount2);
            discountManager.Add(discount3);
            discountManager.Add(discount4);
            discountManager.Add(discount5);
            discountManager.Add(discount6);
            discountManager.Add(discount7);
            discountManager.Add(discount8);
            discountManager.Add(discount9);

            var calculatorManager = new CalculatorManager();
            calculatorManager.SetDiscountManager(discountManager);
            calculatorManager.SetCart(cart);

            Console.WriteLine(calculatorManager.Calculate());
        }
    }
}
