
namespace ch18_Mediator.CRM
{
    public class Label : Component
    {
        public override void Update(){
            System.Console.WriteLine("Label content changed, total count increased by 1");
        }
    }
}