namespace ch21_State.BankAccount
{
    public abstract class AccountState
    {
        private Account account;
        public Account Account{
            get{return account;}
            set{account=value;}
        }
        public abstract void Deposite(decimal amount);
        public abstract void Withdraw(decimal amount);
        public abstract void ComputeInterest();
        public abstract void StateCheck();
    }
}