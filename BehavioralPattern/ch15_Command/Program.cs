using System.Reflection;
using System;
using System.Configuration;
//dotnet add package System.Configuration.ConfigurationManager --version 4.7.0

namespace ch15_Command
{
    class Program
    {
        static void Main(string[] args)
        {
            // Function Button
            {
                /*
                // 1. command
                var cmdStr = ConfigurationManager.AppSettings["command"];
                var cmd = (ch15_Command.FnButton.Command)Assembly.Load("ch15_Command").CreateInstance(cmdStr);
                FnButton.FnButton fn = new FnButton.FnButton(cmd);
                fn.Click();

                // 2. Command Queue
                var q = new ch15_Command.FnButton.CommandQueue();
                q.Add(new ch15_Command.FnButton.HelpCommand());
                q.Add(new ch15_Command.FnButton.ExitCommand());
                var invoker = new ch15_Command.FnButton.CommandQueueInvoker(q);
                invoker.Call();
                */
            }
            // CalculatorAdd: Undo, Redo
            {
                /*
                Calculator.CalculatorAdd calculator = new Calculator.CalculatorAdd();
                Calculator.Command cmd = new Calculator.CmdAdd();
                calculator.Command = cmd;
                calculator.Undo();
                calculator.Redo();
                calculator.Compute(10);
                calculator.Compute(5);
                calculator.Compute(10);
                calculator.Undo();
                calculator.Undo();
                calculator.Redo();
                */
            }
            // Calculator Add && Minus: Undo, Redo
            {
                Calculator.CalculatorFull full = new Calculator.CalculatorFull();
                Calculator.CmdAdd add = new Calculator.CmdAdd();
                Calculator.CmdMinus minus = new Calculator.CmdMinus();
                //full.Undo();
                //full.Redo();
                full.AddCmd = add;
                full.MinusCmd = minus;
                //full.Undo();
                //.Redo();
                full.Add(10);//step01: 0+10=10
                full.Add(5);//step02: 10+5=15
                full.Minus(10);//step03: 15-10=5
                full.Add(5);//step04: 5+5=10
                full.Add(50);//step05: 10+50=60
                full.Undo();//step05-: 60-50=10
                full.Undo();//step04-: 10-5=5
                full.Undo();//step03-: 5+10=15
                full.Undo();//step02-: 15-5=10
                full.Undo();//step01-: 10-10=0
                full.Undo();// no action to undo
                full.Redo();//step01: 0+10=10


                full.Clear();
            }

            // todo: Log cmd serialize, Macro Cmd in file

            // Exercise 1. Switch to Light, Fan
            // Exercise 2. List<cmd> to do Undo and Redo
            // Exercise 3. Macro cmd(list<cmd>) to load logs in batch
            // Exercise 4. BoardScreen: 
            //                 Menu: Open, Create, Edit
            //                 Board: Open, Create, Edit

            Console.ReadKey();
        }
    }
}
