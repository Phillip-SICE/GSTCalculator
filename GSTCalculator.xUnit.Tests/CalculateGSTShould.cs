using FluentAssertions;
using System;
using System.Collections.Generic;
using Xunit;

namespace GSTCalculator.xUnit.Tests
{
    public class CalculateGSTShould
    {
        private Action action;
        private IProductRepository productRepository;
        private IProductService productService;

        public CalculateGSTShould()
        {
            action = null;
            productRepository = new ProductRepository();
            productService = new ProductService(productRepository);
        }

        [Fact]
        public void NotAllowEmptyProductName()
        {
            action = () => new Product("", 1);
            action.Should().Throw<ArgumentException>();
        }

        [Fact]
        public void NotAllowZeroOrNegativePrice()
        {
            action = () => new Product("Apple", 0);
            action.Should().Throw<ArgumentOutOfRangeException>();

            action = () => new Product("Apple", -1);
            action.Should().Throw<ArgumentOutOfRangeException>();
        }

        [Fact]
        public void CalculateGSTForProducts()
        {
            productRepository.CreateProduct(new Product("Apple", 20M));
            productRepository.CreateProduct(new Product("Banana", 3M));

            var actualResult = productService.CalculateGST(productRepository.GetProducts());
            var expectedResult = new List<Decimal>()
            {
                2M,
                0.3M
            };

            actualResult.Should().BeEquivalentTo(expectedResult);
        }
    }
}
