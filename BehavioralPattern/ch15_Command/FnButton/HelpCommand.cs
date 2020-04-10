namespace ch15_Command.FnButton
{
    public class HelpCommand : Command
    {
        private SystemHelp help;
        public HelpCommand(){
            help = new SystemHelp();
        }

        public override void Execute(){
            help.Help();
        }
    }
}