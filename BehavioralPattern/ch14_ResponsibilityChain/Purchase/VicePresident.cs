namespace ch14_ResponsibilityChain.Purchase
{
    public class VicePresident : Approver
    {
        public VicePresident(string name): base(name){

        }

        public override void ProcessRequest(PurchaseRequest request){
            if(request.Amount<100000){
                System.Console.WriteLine("VP {0} approve purchase request: {1}, Amount: {2}, purpose: {3}.", Name, request.Number, request.Amount, request.Purpose);
            }else{
                Successor.ProcessRequest(request);
            }
        }
    }
}