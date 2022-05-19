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
            five.times(2);

            Assert.Equal(10, five.amount);
        }
    }
}
