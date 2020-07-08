namespace ch18_Mediator.CRM
{
    public class ComboBox : Component
    {
        public override void Update(){
            System.Console.WriteLine("ComboBox add one new item : Zhang Wuji");
        }
        public void Select(){
            System.Console.WriteLine("ComboBox select one item : Xiao Longnv");
        }
    }
}