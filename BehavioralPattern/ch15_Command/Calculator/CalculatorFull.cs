using System.Linq;
using System.Collections.Generic;
namespace ch15_Command.Calculator
{

    /// <summary>
    /// An bug: undolist, redolist size not under control.
    /// if the size too large, may cause out of  memory exception
    /// to fix:
    ///       config the limit in config file,
    ///       once size equal limit, empty list
    /// </summary>
    public class CalculatorFull
    {
        private int sum=0;
        private List<KeyValuePair<int, CommandLog>> UndoList = new List<KeyValuePair<int, CommandLog>>();
        private List<KeyValuePair<int, CommandLog>> RedoList = new List<KeyValuePair<int, CommandLog>>();
        public Command AddCmd {get;set;}
        public Command MinusCmd {get;set;}
        public void Add(int value){
            AddUndo(new CommandLog
            {
                Type = CommandType.Add,
                Value = value
            });
            RedoList.Clear();
            sum = AddCmd.Execute(sum, value);
            System.Console.WriteLine("Execute Add({0}), result is : {1}", value, sum);
            RedoList.Clear();
        }
        public void Minus(int value){
            AddUndo(new CommandLog
            {
                Type = CommandType.Minus,
                Value = value
            });
            RedoList.Clear();
            sum = MinusCmd.Execute(sum, value);
            System.Console.WriteLine("Execute Minus({0}), result is : {1}", value, sum);
        }

        public void Undo(){
            var cmdCnt=GetUndoCount();
            if(cmdCnt<1)
            {
                System.Console.WriteLine("Not found undo.");
            }else{
                var log = GetUndo(cmdCnt);
                if (log != null)
                {
                    if ((log.Type == CommandType.Add || log.Type == CommandType.AddUndo || log.Type == CommandType.AddRedo) && AddCmd != null)
                    {
                        RemoveUndo();
                        AddRedo(new CommandLog
                        {
                            Type = CommandType.AddUndo,
                            Value = log.Value
                        });
                        sum = AddCmd.Undo(sum,log.Value);
                        System.Console.WriteLine("Execute undo, result is : {0}", sum);
                    }
                    else if ((log.Type == CommandType.Minus || log.Type == CommandType.MinusUndo || log.Type == CommandType.MinusRedo) && MinusCmd != null)
                    {
                        RemoveUndo();
                        AddRedo(new CommandLog
                        {
                            Type = CommandType.MinusUndo,
                            Value = log.Value
                        });
                        sum = MinusCmd.Undo(sum, log.Value);
                        System.Console.WriteLine("Execute undo, result is : {0}", sum);
                    }
                    else
                    {
                        System.Console.WriteLine("Invalid undo.");
                    }
                }
                else
                {
                    System.Console.WriteLine("You have no valid undo.");
                }
            }
        }

        public void Redo(){
            var cmdCnt=GetRedoCount();
            if(cmdCnt<1)
            {
                System.Console.WriteLine("Not found redo.");
            }else{
                var log = GetRedo(cmdCnt);
                if (log != null)
                {
                    if ((log.Type == CommandType.Add || log.Type == CommandType.AddUndo || log.Type == CommandType.AddRedo) && AddCmd != null)
                    {
                        RemoveRedo();
                        AddUndo(new CommandLog
                        {
                            Type = CommandType.AddRedo,
                            Value = log.Value
                        });
                        sum = AddCmd.Redo(sum, log.Value);
                        System.Console.WriteLine("Execute redo, result is : {0}", sum);
                    }
                    else if ((log.Type == CommandType.Minus || log.Type == CommandType.MinusUndo || log.Type == CommandType.MinusRedo) && MinusCmd != null)
                    {
                        RemoveRedo();
                        AddUndo(new CommandLog
                        {
                            Type = CommandType.MinusRedo,
                            Value = log.Value
                        });
                        sum = MinusCmd.Redo(sum, log.Value);
                        System.Console.WriteLine("Execute redo, result is : {0}", sum);
                    }
                    else
                    {
                        System.Console.WriteLine("Invalid redo.");
                    }
                }
                else
                {
                    System.Console.WriteLine("You have no valid undo.");
                }
            }
        }

        public void AddUndo(CommandLog log)
        {
            var count = GetUndoCount();
            UndoList.Add(new KeyValuePair<int, CommandLog>(count + 1, log));
        }
        public int GetUndoCount()
        {
            var count = 0;
            if (UndoList != null)
            {
                count = UndoList.Count;
            }
            return count;
        }
        public CommandLog GetUndo(int key)
        {
            return UndoList.FirstOrDefault(kvp => kvp.Key == key).Value;
        }
        private void RemoveUndo()
        {
            var count = GetUndoCount();
            if (count > 0)
            {
                UndoList.RemoveAt(count-1);
            }
        }

        public void AddRedo(CommandLog log)
        {
            var count = GetRedoCount();
            RedoList.Add(new KeyValuePair<int, CommandLog>(count + 1, log));
        }
        public int GetRedoCount()
        {
            var count = 0;
            if (RedoList != null)
            {
                count = RedoList.Count;
            }
            return count;
        }
        public CommandLog GetRedo(int key)
        {
            return RedoList.FirstOrDefault(kvp => kvp.Key == key).Value;
        }
        private void RemoveRedo()
        {
            var count = GetRedoCount();
            if (count > 0)
            {
                RedoList.RemoveAt(count-1);
            }
        }
        public void Clear(){
            sum=0;
            UndoList=new List<KeyValuePair<int, CommandLog>>();
            RedoList= new List<KeyValuePair<int, CommandLog>>();
        }
    }
}