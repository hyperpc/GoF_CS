namespace ch16_Interpreter.Robot
{
    public class SentenceNode : AbstractNode
    {
        private AbstractNode direction;
        private AbstractNode action;
        private AbstractNode distance;

        public SentenceNode(AbstractNode direction,AbstractNode action,AbstractNode distance){
            this.direction=direction;
            this.action=action;
            this.distance=distance;
        }

        public override string Interpret(){
            return action.Interpret() + direction.Interpret() + distance.Interpret();
        }
    }
}