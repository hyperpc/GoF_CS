namespace ch16_Interpreter.Robot
{
    public class ActionNode : AbstractNode
    {
        private string action;

        public ActionNode(string action){
            this.action=action;
        }
        
        public override string Interpret(){
            var rs="invalid action";
            switch(action)
            {
                case "move":
                    rs="move";
                    break;
                case "run":
                    rs="run";
                    break;
                default:
                    break;
            }
            return rs;
        }
    }
}