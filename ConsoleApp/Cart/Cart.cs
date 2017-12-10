using System.Collections.Generic;

namespace ConsoleApp
{
    /// <summary>
    /// Корзина с продуктами
    /// </summary>
    public class Cart : ICart
    {
        private readonly List<IProduct> _products = new List<IProduct>();

        /// <summary>
        /// Добавить продукт в корзину
        /// </summary>
        /// <param name="product"></param>
        public void AddProduct(IProduct product)
        {
            _products.Add(product);
        }

        /// <summary>
        /// Получить продукты из корзины
        /// </summary>
        /// <returns></returns>
        public List<IProduct> GetProducts()
        {
            return _products;
        }
        /// <summary>
        /// Удалить продукт из корзины по индексу
        /// </summary>
        /// <param name="index"></param>
        public void RemoveProductByIndex(int index)
        {
            if (index >= 0 && index < _products.Count)
                _products.RemoveAt(index);
        }
    }
}
