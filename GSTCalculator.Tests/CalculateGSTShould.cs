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
        }

        [Test]
        public void CalculateGSTForProduct()
        {
            var productUnderTest = new Product("Apple", 10);

            Decimal resultGST = 1M;

            Assert.That(resultGST, Is.EqualTo(productUnderTest.CalculateGST()));
        }
    }
}
