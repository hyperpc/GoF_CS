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

            // 


            Console.ReadKey();
        }
    }
}
