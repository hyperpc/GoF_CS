
namespace ch18_Mediator.CRM
{
    public class List : Component
    {
        public override void Update(){
            System.Console.WriteLine("List add one new item : Zhang Wuji");
        }
        public void Select(){
            System.Console.WriteLine("List select one item : Xiao Longnv");
        }
    }
}