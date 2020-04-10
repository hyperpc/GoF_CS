namespace ch14_ResponsibilityChain.Purchase
{
    public abstract class Approver
    {
        protected Approver Successor;
        protected string Name;
        public Approver(string name){
            Name = name;
        }
        public void SetSuccessor(Approver successor){
            Successor = successor;
        }

        public abstract void ProcessRequest(PurchaseRequest request);
    }
}