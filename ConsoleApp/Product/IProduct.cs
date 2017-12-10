namespace ConsoleApp
{
    public interface IProduct
    {
        int Id { get; set; }
        bool IsCalculate { get; set; }
        string Name { get; set; }
        decimal Price { get; set; }
        ProductType Type { get; set; }
    }
}