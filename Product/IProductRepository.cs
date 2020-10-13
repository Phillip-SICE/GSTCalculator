using System.Collections.Generic;

namespace GSTCalculator
{
    public interface IProductRepository
    {
        void CreateProduct(Product product);
        List<Product> GetProducts();
    }
}
