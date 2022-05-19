namespace Exchange.Service
{
    public class Dollar
    {
        public int amount;

        public Dollar(int amount)
        {
            this.amount = amount;
        }

        public override bool Equals(object obj)
        {
            Dollar dollar = (Dollar)obj;
            return amount == dollar.amount;
        }

        public Dollar times(int multiplier)
        {
            return new Dollar(multiplier * amount);
        }
    }
}