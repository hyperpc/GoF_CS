namespace ch14_ResponsibilityChain.Purchase
{
    public class PurchaseRequest
    {
        public double Amount{get;set;}
        public int Number{get;set;}
        public string Purpose{get;set;}

        public PurchaseRequest(double amount, int number, string purpose){
            Amount = amount;
            Number = number;
            Purpose = purpose;
        }
    }
}