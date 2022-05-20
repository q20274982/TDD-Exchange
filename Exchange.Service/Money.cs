using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exchange.Service
{
    public abstract class Money
    {
        protected int amount;

        public override bool Equals(object obj)
        {
            Money money = (Money)obj;
            return amount == money.amount
                && GetType().Equals(money.GetType());
        }

        public static Dollar dollar(int amount)
        {
            return new Dollar(amount);
        }

        public abstract Money times(int multiplier);
    }
}
