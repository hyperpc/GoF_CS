namespace ch15_Command.Calculator
{
    public enum CommandType
    {
        Add=0,
        AddUndo=1,
        AddRedo=2,
        Minus=10,
        MinusUndo=11,
        MinusRedo=12,
        Multiply=20,
        MultiplyUndo=21,
        MultiplyRedo=22,
        Divided=30,
        DividedUndo=31,
        DividedRedo=32
    }
}