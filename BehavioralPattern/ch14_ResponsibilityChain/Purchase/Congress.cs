namespace ch14_ResponsibilityChain.Purchase
{
    public class Congress : Approver
    {
        public Congress(string name): base(name){

        }

        public override void ProcessRequest(PurchaseRequest request){
            System.Console.WriteLine("Congress {0} approve purchase request: {1}, Amount: {2}, purpose: {3}.", Name, request.Number, request.Amount, request.Purpose);
        }
    }
}