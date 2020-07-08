namespace ch18_Mediator.CRM
{
    public class TextBox : Component
    {
        public override void Update(){
            System.Console.WriteLine("Clear Textbox after add new info successfully");
        }
        public void Select(){
            System.Console.WriteLine("Textbox : Xiao Longnv");
        }
    }
}