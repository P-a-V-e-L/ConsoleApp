using System.Collections.Generic;

namespace ConsoleApp
{
    /// <summary>
    /// Корзина с продуктами
    /// </summary>
    public class Cart
    {
        private readonly List<Product> _products = new List<Product>();

        /// <summary>
        /// Добавить продукт в корзину
        /// </summary>
        /// <param name="product"></param>
        public void AddProduct(Product product)
        {
            _products.Add(product);
        }

        /// <summary>
        /// Получить продукты из корзины
        /// </summary>
        /// <returns></returns>
        public List<Product> GetProducts()
        {
            return _products;
        }
    }
}
