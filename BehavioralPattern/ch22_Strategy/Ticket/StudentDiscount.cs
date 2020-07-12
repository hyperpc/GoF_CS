namespace ch22_Strategy.Ticket
{
    public class StudentDiscount : Discount
    {
        private const double _DISCOUNT=0.8;
        public double Calculate(double price){
            System.Console.WriteLine("学生票：");
            return price*_DISCOUNT;
        }
    }
}