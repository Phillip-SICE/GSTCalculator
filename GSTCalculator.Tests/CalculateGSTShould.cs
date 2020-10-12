using NUnit.Framework;
using GSTCalculator;
using System;
using System.Collections.Generic;
using System.Text;

namespace GSTCalculator.Tests
{
    [TestFixture]
    public class CalculateGSTShould
    {

        [Test]
        public void NotAllowEmptyProductName()
        {
            Assert.That(() => new Product("", 1), Throws.TypeOf<ArgumentException>());
        }

        [Test]
        public void NotAllowZeroOrNegativePrice()
        {
            Assert.That(() => new Product("Apple", 0), Throws.TypeOf<ArgumentOutOfRangeException>());
            Assert.That(() => new Product("Apple", -1), Throws.TypeOf<ArgumentOutOfRangeException>());
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
            

            for(var i = 0; i < 2; i++)
            {
                var expected = expectedResult[i];
                var actual = actualResult[i];
                Assert.That(expected, Is.EqualTo(actual));
            }
        }
    }
}
