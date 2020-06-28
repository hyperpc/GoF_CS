using System.Runtime.CompilerServices;
namespace ch16_Interpreter.Robot
{
    public class AndNode : AbstractNode
    {
        private AbstractNode left;
        private AbstractNode right;
        public AndNode(AbstractNode left, AbstractNode right){
            this.left= left;
            this.right=right;
        }
        public override string Interpret(){
            return left.Interpret() + ", and then " + right.Interpret();
        }
    }
}