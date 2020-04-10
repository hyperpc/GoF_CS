namespace ch15_Command.FnButton
{
    public class CommandQueueInvoker
    {
        private CommandQueue queue;
        public CommandQueueInvoker(CommandQueue q){
            queue = q;
        }
        public void Call(){
            queue.Execute();
        }
    }
}