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
            Money five = Money.dollar(5);
            Assert.Equal(Money.dollar(10), five.times(2));
            Assert.Equal(Money.dollar(15), five.times(3));
        }

        [Fact]
        public void testEquality()
        {
            Assert.Equal(Money.dollar(5), Money.dollar(5));
            Assert.NotEqual(Money.dollar(5), Money.dollar(6));
            Assert.Equal(Money.franc(5), Money.franc(5));
            Assert.NotEqual(Money.franc(5), Money.franc(6));

            Assert.False(Money.franc(5).Equals(Money.dollar(5)));
        }

        [Fact]
        public void testFrancMultiplication()
        {
            Franc five = Money.franc(5);
            Assert.Equal(Money.franc(10), five.times(2));
            Assert.Equal(Money.franc(15), five.times(3));
        }

        [Fact]
        public void testCurrency()
        {
            Assert.Equal("USD", Money.dollar(1).currency());
            Assert.Equal("CHF", Money.franc(1).currency());

        }
    }
}
