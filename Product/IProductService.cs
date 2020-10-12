using System;
using System.Collections.Generic;
using System.Text;

namespace GSTCalculator
{
    public interface IProductService
    {
        List<decimal> CalculateGST(List<Product> products);
    }
}
