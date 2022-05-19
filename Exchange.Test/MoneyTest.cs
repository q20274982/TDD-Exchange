using Exchange.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Exchange.Test
{
    public class MoneyTest
    {
        [Fact]
        public void testMultiplication()
        {
            Dollar five = new Dollar(5);
            Dollar product = five.times(2);
            Assert.Equal(10, product.amount);

            product = five.times(3);
            Assert.Equal(15, product.amount);
        }

        [Fact]
        public void testEquality()
        {
            Assert.Equal(new Dollar(5), new Dollar(5));
        }
    }
}
