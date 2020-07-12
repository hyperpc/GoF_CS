namespace ch22_Strategy.Ticket
{
    public class VIPDiscount : Discount
    {
        private const double _DISCOUNT=0.5;
        public double Calculate(double price){
            System.Console.WriteLine("VIP票：");
            System.Console.WriteLine("增加积分！");
            return price*_DISCOUNT;
        }
    }
}