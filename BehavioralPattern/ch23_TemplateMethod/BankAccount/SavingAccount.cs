namespace ch23_TemplateMethod.BankAccount
{
    public class SavingAccount : Account
    {
        public override void CalculateInterest(){
            System.Console.WriteLine("定期利息!");
        }
    }
}