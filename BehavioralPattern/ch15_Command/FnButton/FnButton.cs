namespace ch15_Command.FnButton
{
    public class FnButton
    {
        private Command command;
        public FnButton(Command cmd){
            command = cmd;
        }

        public void Click(){
            System.Console.WriteLine("Click Function Button.");
            command.Execute();
        }
    }
}