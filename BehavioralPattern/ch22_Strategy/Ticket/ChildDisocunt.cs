using System;
namespace ch22_Strategy.Ticket
{
    public class ChildDiscount : Discount
    {
        private const double _DISCOUNT=10;
        public double Calculate(double price){
            System.Console.WriteLine("儿童票：");
            return price-_DISCOUNT;
        }
    }
}