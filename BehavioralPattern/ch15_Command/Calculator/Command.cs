
namespace ch15_Command.Calculator
{
    public abstract class Command
    {
        public abstract int Execute(int sum, int value);
        public abstract int Undo(int sum, int value);
        public abstract int Redo(int sum, int value);

    }
}