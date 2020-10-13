using System.Collections.Generic;

namespace GSTCalculator
{
    public interface IProductService
    {
        List<decimal> CalculateGST(List<Product> products);
    }
}
