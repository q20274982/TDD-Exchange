namespace Exchange.Service
{
    public class Franc
    {
        private int amount;

        public Franc(int amount)
        {
            this.amount = amount;
        }

        public override bool Equals(object obj)
        {
            Franc dollar = (Franc)obj;
            return amount == dollar.amount;
        }

        public Franc times(int multiplier)
        {
            return new Franc(multiplier * amount);
        }
    }
}