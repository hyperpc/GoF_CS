using System.Collections;
using System.Net;
namespace ch16_Interpreter.Robot
{
    public class InstructionHandler
    {
        private AbstractNode node;

        public void Handle(string instructions){
            AbstractNode left, right;
            AbstractNode direction, action, distance;
            Stack stack = new Stack();
            string[] words = instructions.Split(' ');
            for(int i=0; i<words.Length; i++){
                if(words[i].Equals("and")){
                    left = (AbstractNode)stack.Pop();
                    direction = new DirectionNode(words[++i]); 
                    action = new ActionNode(words[++i]); 
                    distance = new DistanceNode(words[++i]); 
                    right = new SentenceNode(direction,action,distance);
                    stack.Push(new AndNode(left, right));
                }else{
                    direction = new DirectionNode(words[i]); 
                    action = new ActionNode(words[++i]); 
                    distance = new DistanceNode(words[++i]); 
                    left = new SentenceNode(direction,action,distance);
                    stack.Push(left);
                }
            }
            this.node=(AbstractNode)stack.Pop();
        }

        public string Output(){
            return node.Interpret();
        }
    }
}