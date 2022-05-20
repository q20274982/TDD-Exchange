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
            Assert.Equal(new Franc(5), new Franc(5));
            Assert.NotEqual(new Franc(5), new Franc(6));

            Assert.False(new Franc(5).Equals(new Dollar(5)));
        }

        [Fact]
        public void testFrancMultiplication()
        {
            Franc five = new Franc(5);
            Assert.Equal(new Franc(10), five.times(2));
            Assert.Equal(new Franc(15), five.times(3));
        }
    }
}
