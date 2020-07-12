namespace ch21_State.BankAccount
{
    public class OverdraftState : AccountState
    {
        public OverdraftState(Account account){
            this.Account=account;
        }
        public OverdraftState(AccountState state){
            this.Account=state.Account;
        }
        public override void Deposite(decimal amount){
            Account.Balance=Account.Balance+amount;
            StateCheck();
        }
        public override void Withdraw(decimal amount){
            Account.Balance=Account.Balance-amount;
            StateCheck();
        }
        public override void ComputeInterest(){
            System.Console.WriteLine("计算利息!");
        }
        public override void StateCheck(){
            if(Account.Balance>0){
                Account.SetState(new NormalState(this));
            }else if(Account.Balance==-2000){
                Account.SetState(new RestrictedState(this));
            } else if(Account.Balance<-2000){
                System.Console.WriteLine("操作受限!");
            }
        }
    }
}