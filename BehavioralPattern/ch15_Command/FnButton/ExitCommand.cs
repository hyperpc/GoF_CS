namespace ch15_Command.FnButton
{
    public class ExitCommand : Command
    {
        private SystemExit exit;
        public ExitCommand(){
            exit = new SystemExit();
        }

        public override void Execute(){
            exit.Exit();
        }
    }
}