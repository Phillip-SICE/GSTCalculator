using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;


namespace GSTCalculator
{
    public class CalculateGSTShould
    {
        [Fact]
        public void NotAllowEmptyProductName()
        {
            Action action = () => new Product("", 1);
            action.Should().Throw<ArgumentException>();
        }
    }
}
