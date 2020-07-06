//using Internal;
using System.Runtime.InteropServices;
using System.Reflection.Metadata;
using System;

namespace ch16_Interpreter
{
    class Program
    {
        static void Main(string[] args)
        {
            // Robot
            {
                var instructions = "down run 10 and left move 20";
                var handler = new ch16_Interpreter.Robot.InstructionHandler();
                handler.Handle(instructions);

                var outString = handler.Output();
                System.Console.WriteLine(outString);

                instructions = "up move 5 and down run 10 and left move 5";
                handler.Handle(instructions);
                outString = handler.Output();
                System.Console.WriteLine(outString);
            }

            // Calculator
            // 1. abstract AbstractNode{abstract string Interpret();}
            // 2. CalculatorAction : AbstractNode{CalculatorAction(string operator); override Interpret(){}}
            //    MultipleAction : CalculatorAction{override Interpret(){ * }}
            //    DivideAction : CalculatorAction{override Interpret(){ /}}
            //    ModeAction : CalculatorAction{override Interpret(){ %}}
            // 3. SentenceNode : AbstractNode{SentenceNode(int num1, int num2, CalculatorAction action); override Interpret(){}}
            // 4. InstructionHandler{ -AbstractNode; +Handle(string instruction){}}

            // BooleenOperator

            // DBSync
            // COPY VIEW FROM srcDB TO DesDB
            // MOVE TABLE FROM Student FROM srcDB TO desDB


            Console.ReadKey();
        }
    }
}
