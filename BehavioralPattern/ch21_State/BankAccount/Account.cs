namespace ch21_State.BankAccount
{
    public class Account
    {
        private AccountState state;
        private string owner;
        private decimal balance=0;
        public Account(string owner, decimal init){
            this.owner=owner;
            this.balance=init;
            this.state = new NormalState(this);
            System.Console.WriteLine($"{this.owner}开户,初始金额为{this.balance}");
            System.Console.WriteLine("-----------------------------");
        }
        public decimal Balance{
            get{return balance;}
            set{balance=value;}
        }
        public void SetState(AccountState state){
            this.state=state;
        }
        public void Deposite(decimal amount){
            System.Console.WriteLine($"{this.owner}存款{amount}元");
            state.Deposite(amount);
            System.Console.WriteLine($"现在余额为{this.Balance}");
            System.Console.WriteLine($"现在状态为{this.state.GetType().ToString()}");
            System.Console.WriteLine("-----------------------------");
        }
        public void Withdraw(decimal amount){
            System.Console.WriteLine($"{this.owner}取款{amount}元");
            state.Withdraw(amount);
            System.Console.WriteLine($"现在余额为{this.Balance}");
            System.Console.WriteLine($"现在状态为{this.state.GetType().ToString()}");
            System.Console.WriteLine("-----------------------------");
        }
        public void ComputeInterest(){
            state.ComputeInterest();
        }
    }
}