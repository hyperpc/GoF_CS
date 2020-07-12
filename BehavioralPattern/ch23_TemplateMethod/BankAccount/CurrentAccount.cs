namespace ch23_TemplateMethod.BankAccount
{
    public class CurrentAccount : Account
    {
        public override void CalculateInterest(){
            System.Console.WriteLine("活期利息!");
        }
    }
}