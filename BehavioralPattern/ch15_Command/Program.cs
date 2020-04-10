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
            // CAlculator: Undo, Redo
            {
                //List<keyvaluepair<int, cmd>> -> do Undo, and fill in Redo
                //List<keyvaluepair<int, cmd>> -> do Redo, and fill in Undo
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
