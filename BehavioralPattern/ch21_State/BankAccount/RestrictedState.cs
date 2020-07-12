namespace ch21_State.BankAccount
{
    public class RestrictedState : AccountState
    {
        public RestrictedState(Account account){
            this.Account=account;
        }
        public RestrictedState(AccountState state){
            this.Account=state.Account;
        }
        public override void Deposite(decimal amount){
            Account.Balance=Account.Balance+amount;
            StateCheck();
        }
        public override void Withdraw(decimal amount){
            System.Console.WriteLine("账号受限，取款失败!");
        }
        public override void ComputeInterest(){
            System.Console.WriteLine("计算利息!");
        }
        public override void StateCheck(){
            if(Account.Balance>0){
                Account.SetState(new NormalState(this));
            }else if(Account.Balance>-2000){
                Account.SetState(new OverdraftState(this));
            }
        }
    }
}