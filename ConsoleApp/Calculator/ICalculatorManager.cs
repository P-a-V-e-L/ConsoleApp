namespace ConsoleApp
{
    public interface ICalculatorManager
    {
        decimal Calculate();
        void SetCart(ICart cart);
        void SetDiscountManager(IDiscountManager discountManager);
    }
}