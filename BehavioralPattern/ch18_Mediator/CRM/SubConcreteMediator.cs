namespace ch18_Mediator.CRM
{
    public class SubConcreteMediator:ConcreteMediator
    {
        public Label label;
        public override void ComponentChanged(Component c){
            if(c==btn){
                System.Console.WriteLine("--click button--");
                list.Update();
                comboBox.Update();
                textBox.Update();
                label.Update();
            }else if(c==list){
                System.Console.WriteLine("--select item from list--");
                comboBox.Select();
                textBox.Select();
            }else if(c==comboBox){
                System.Console.WriteLine("--select item from comboBox--");
                comboBox.Select();
                textBox.Select();
            }
        }
    }
}