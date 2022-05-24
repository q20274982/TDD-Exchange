using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exchange.Service
{
    public abstract class Money
    {
        protected int _amount;
        protected string _currency;

        public Money(int amount, string currency)
        {
            this._amount = amount;
            this._currency = currency;
        }

        public override bool Equals(object obj)
        {
            Money money = (Money)obj;
            return _amount == money._amount
                && GetType().Equals(money.GetType());
        }

        public static Dollar dollar(int amount)
        {
            return new Dollar(amount, "USD");
        }

        public static Franc franc(int amount)
        {
            return new Franc(amount, "CHF");
        }

        public abstract Money times(int multiplier);

        public string currency()
        {
            return _currency;
        }
    }
}
