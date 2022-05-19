namespace Exchange.Service
{
    public class Franc : Money
    {
        public Franc(int amount)
        {
            this.amount = amount;
        }

        public Franc times(int multiplier)
        {
            return new Franc(multiplier * amount);
        }
    }
}