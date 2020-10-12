using System;
using System.Collections.Generic;
using System.Text;

namespace GSTCalculator
{
    public class ProductRepository : IProductRepository
    {
        private List<Product> _products;

        public ProductRepository()
        {
            _products = new List<Product>();
        }

        public void CreateProduct(Product product)
        {
            this._products.Add(product);
        }

        public List<Product> GetProducts()
        {
            return this._products;
        }
    }
}
