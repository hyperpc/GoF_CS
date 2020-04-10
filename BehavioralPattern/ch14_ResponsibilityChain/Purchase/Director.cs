namespace ch14_ResponsibilityChain.Purchase
{
    public class Director : Approver
    {
        public Director(string name): base(name){

        }

        public override void ProcessRequest(PurchaseRequest request){
            if(request.Amount<50000){
                System.Console.WriteLine("Director {0} approve purchase request: {1}, Amount: {2}, purpose: {3}.", Name, request.Number, request.Amount, request.Purpose);
            }else{
                this.Successor.ProcessRequest(request);
            }
        }
    }
}