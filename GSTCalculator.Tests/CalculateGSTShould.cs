using FluentAssertions;
using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace GSTCalculator.Tests
{
    [TestFixture]
    public class CalculateGSTShould
    {

        [Test]
        public void NotAllowEmptyProductName()
        {
            Action action = () => new Product("", 1);
            action.Should().Throw<ArgumentException>();
        }

        [Test]
        public void NotAllowZeroOrNegativePrice()
        {
            Action action1 = () => new Product("Apple", 0);
            Action action2 = () => new Product("Apple", -1);

            action1.Should().Throw<ArgumentOutOfRangeException>();
            action2.Should().Throw<ArgumentOutOfRangeException>();
        }

        [Test]
        public void CalculateGSTForProducts()
        {
            var productRepository = new ProductRepository();
            var productService = new ProductService(productRepository);
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
