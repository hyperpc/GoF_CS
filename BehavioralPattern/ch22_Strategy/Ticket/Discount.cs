namespace ch22_Strategy.Ticket
{
    public interface Discount
    {
        public double Calculate(double price);
    }
}