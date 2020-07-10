using System;
using ch19_Memento.Chessman;

namespace ch19_Memento
{
    class Program
    {
        private static int index=-1;
        private static MementoCaretaker mc = new MementoCaretaker();
        static void Main(string[] args)
        {
            // 1. Chessman - one time restore
            {
                /*
                MementoCaretaker careTaker = new MementoCaretaker();
                MementoOriginator chess = new MementoOriginator("车",1,1);
                Display(chess);
                careTaker.SetMemento(chess.Save());
                chess.Y=4;
                Display(chess);
                careTaker.SetMemento(chess.Save());
                Display(chess);
                chess.X=5;
                Display(chess);
                System.Console.WriteLine("**************悔棋*************");
                chess.Restore(careTaker.GetMemento());
                Display(chess);
                */
            }
            // 2. Chessman - more than one time to restore
            {
                MementoOriginator chess = new MementoOriginator("车",1,1);
                Play(chess);
                chess.Y=4;
                Play(chess);
                chess.X=5;
                Play(chess);
                Undo(chess,index);
                Undo(chess,index);
                Redo(chess,index);
                Redo(chess,index);
            }

            // 3.Stack to restore

            // 4. RPG game
            // if player died, can reborm from one restore point

            Console.ReadLine();
        }
        public static void Display(MementoOriginator chess){
            System.Console.WriteLine($"Chess {chess.Label}'s current position : Rows[{chess.X}], Columns[{chess.Y}].");
        }
        public static void Play(MementoOriginator chess){
            mc.SetMementoToList(chess.Save());
            index++;
            System.Console.WriteLine($"Chess {chess.Label}'s current position : Rows[{chess.X}], Columns[{chess.Y}].");
        }
        public static void Undo(MementoOriginator chess, int i){
            System.Console.WriteLine("**************悔棋*************");
            index--;
            chess.Restore(mc.GetMementoByIndex(i-1));
            System.Console.WriteLine($"Chess {chess.Label}'s current position : Rows[{chess.X}], Columns[{chess.Y}].");
        }
        public static void Redo(MementoOriginator chess, int i){
            System.Console.WriteLine("**************撤销悔棋*************");
            index++;
            chess.Restore(mc.GetMementoByIndex(i+1));
            System.Console.WriteLine($"Chess {chess.Label}'s current position : Rows[{chess.X}], Columns[{chess.Y}].");
        }
    }
}
