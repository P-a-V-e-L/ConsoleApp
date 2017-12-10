using System.Collections.Generic;

namespace ConsoleApp
{
    public interface ICart
    {
        void AddProduct(IProduct product);
        List<IProduct> GetProducts();
        void RemoveProductByIndex(int index);
    }
}