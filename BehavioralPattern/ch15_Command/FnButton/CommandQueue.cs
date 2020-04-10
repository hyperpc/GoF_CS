using System.Collections.Generic;
namespace ch15_Command.FnButton
{
    public class CommandQueue
    {
        private List<Command> cmds = new List<Command>();
        public void Add(Command cmd){
            cmds.Add(cmd);
        }
        public void Remove(Command cmd){
            cmds.Remove(cmd);
        }
        public void Execute(){
            foreach(var cmd in cmds){
                cmd.Execute();
            }
        }
    }
}