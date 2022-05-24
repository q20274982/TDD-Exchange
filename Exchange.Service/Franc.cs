namespace Exchange.Service
{
    public class Franc : Money
    {
        public Franc(int amount, string currency) : base(amount, currency)
        {
        }

        public override Money times(int multiplier)
        {
            return franc(_amount * multiplier);
        }

        public override string currency()
        {
            return _currency;
        }
    }
}