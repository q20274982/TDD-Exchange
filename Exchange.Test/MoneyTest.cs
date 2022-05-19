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
            Assert.Equal(new Dollar(10), five.times(2));
            Assert.Equal(new Dollar(15), five.times(3));
        }

        [Fact]
        public void testEquality()
        {
            Assert.Equal(new Dollar(5), new Dollar(5));
            Assert.NotEqual(new Dollar(5), new Dollar(6));
        }
    }
}
