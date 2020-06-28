namespace ch16_Interpreter.Robot
{
    public class DirectionNode : AbstractNode
    {        
        private string direction;

        public DirectionNode(string direction){
            this.direction=direction;
        }
        
        public override string Interpret(){
            var rs=" invalid direction ";
            switch(direction){
                case "up":
                    rs=" to up ";
                    break;
                case "down":
                    rs=" to down ";
                    break;
                case "left":
                    rs=" to left ";
                    break;
                case "right":
                    rs=" to right ";
                    break;
                default:
                    break;
            }
            return rs;
        }
    }
}