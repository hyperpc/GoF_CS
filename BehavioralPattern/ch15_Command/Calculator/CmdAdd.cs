
namespace ch15_Command.Calculator
{
    public class CmdAdd : Command
    {
        private OperatorAdd add = new OperatorAdd();

        public override int Execute(int sum, int value){
            sum = add.Add(sum, value);
            return sum;
        }

        public override int Undo(int sum, int value){
            sum = add.Add(sum, -value);
            return sum;
        }

        public override int Redo(int sum, int value)
        {
            sum = add.Add(sum, value);
            return sum;
        }
        
    }
}