
namespace ch15_Command.Calculator
{
    public class CmdMinus:Command
    {        
        private OperatorMinus minus = new OperatorMinus();

        public override int Execute(int sum, int value){
            sum = minus.Minus(sum, value);
            return sum;
        }

        public override int Undo(int sum, int value)
        {
            sum = minus.Minus(sum, -value);
            return sum;
        }

        public override int Redo(int sum, int value)
        {
            sum = minus.Minus(sum, value);
            return sum;
        }
    }
}