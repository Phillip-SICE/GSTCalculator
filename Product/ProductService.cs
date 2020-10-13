using System.Collections.Generic;

namespace GSTCalculator
{
    public class ProductService : IProductService
    {
        private IProductRepository _productRepositoy;
        public ProductService(IProductRepository productRepository)
        {
            this._productRepositoy = productRepository;
        }

        public List<decimal> CalculateGST(List<Product> products)
        {
            var results = new List<decimal>();

            foreach(var product in products)
            {
                results.Add(product.Price * 0.1M);
            }

            return results;
        }
    }
}
