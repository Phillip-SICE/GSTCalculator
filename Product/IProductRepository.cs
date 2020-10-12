using System;
using System.Collections.Generic;
using System.Text;

namespace GSTCalculator
{
    public interface IProductRepository
    {
        void CreateProduct(Product product);
        List<Product> GetProducts();
    }
}
