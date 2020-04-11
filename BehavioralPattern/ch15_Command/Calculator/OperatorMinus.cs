namespace ch15_Command.Calculator
{
    public class OperatorMinus
    {
        public int Minus(int sum, int value){
            sum-=value;
            return sum;
        }
    }
}