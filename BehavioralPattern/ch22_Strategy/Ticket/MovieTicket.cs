namespace ch22_Strategy.Ticket
{
    public class MovieTicket
    {
        private double price;
        private Discount discount;
        public void SetDiscount(Discount discount){
            this.discount=discount;
        }
        public double Price{
            get{return discount.Calculate(this.price);}
            set{price=value;}
        }
    }
}