namespace ch15_Command.Calculator
{
    // this class is not used, as basic abstract class Command has changed.
    public class CalculatorAdd
    {
        /*
        public Command Command{get;set;}
        public void Compute(int value){
            int sum = Command.Execute(value);
            System.Console.WriteLine("Execute calculator, result is : {0}", sum);
        }

        public void Undo(){                
            var undoCnt=Command.GetUndoListCount();
            if(undoCnt<1){
                System.Console.WriteLine("You have no action to undo.");
            }else{
                var sum = Command.Undo();
                System.Console.WriteLine("Execute Undo, result is : {0}", sum);
            }
        }

        public void Redo(){
            var redoCnt=Command.GetRedoListCount();
            if(redoCnt<1){
                System.Console.WriteLine("You have no action to redo.");
            }else{
                var sum = Command.Redo();
                System.Console.WriteLine("Execute Redo, result is : {0}", sum);
            }
        }
        */
    }
}