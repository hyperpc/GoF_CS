namespace ch23_TemplateMethod.BankAccount
{
    public abstract class Account
    {
        // basic method
        public bool Validate(string account, string password){
            System.Console.WriteLine($"账户: {account}");
            System.Console.WriteLine($"密码: {password}");
            if(account.Equals("hyp") && password.Equals("1234")){
                return true;
            }
            return false;
        }
        // abstract method
        public abstract void CalculateInterest();
        // basic method
        public void Display(){
            System.Console.WriteLine("显示利息！");
        }
        // Template Method
        public void Handle(string account, string password){
            if(!Validate(account, password)){
                System.Console.WriteLine("账号或密码错误！");
                return;
            }
            CalculateInterest();
            Display();
        }
    }
}