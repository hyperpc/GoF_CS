namespace ch16_Interpreter.Robot
{
    public class DistanceNode : AbstractNode
    {
        private string distance;

        public DistanceNode(string distance){
            this.distance=distance;
        }
        
        public override string Interpret(){
            return this.distance;
        }
    }
}