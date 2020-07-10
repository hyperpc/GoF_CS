using System.Reflection.Metadata;
using System;
using ch20_Observer.AllyTeam;
using ch20_Observer.DelegateEvent;

namespace ch20_Observer
{
    class Program
    {
        public Program(EventTest test){
            test.OnUserInput+=new EventTest.UserInput(Handler);
            test.OnUserInput+=new EventTest.UserInput(HandlerMore);

            //test.OnUserInput-=new EventTest.UserInput(Handle);
        }
        static void Main(string[] args)
        {
            // 1. Ally
            {
                /*
                Subject_Ally acc = new Subject_AllyCtrlCenter("金庸群侠");
                IObserver_Ally player1, player2, player3, player4;
                player1=new Observer_Player("杨过");
                acc.Join(player1);
                player2=new Observer_Player("令狐冲");
                acc.Join(player2);
                player3=new Observer_Player("张无忌");
                acc.Join(player3);
                player4=new Observer_Player("段誉");
                acc.Join(player4);

                player1.BeAttacked(acc);
                */
            }

            // 2. Delegate and Event
            {
                EventTest test = new EventTest();
                Program program = new Program(test);
                test.Method();
            }

            // 3. Subject => Cat (Miao(){}; Join(){})
            //    Observer => Mouse {Run(){}}, Master{ Wake(){}}

            // 4. School
            // Subject => School(){ChangeName(){}; Join(){}}
            // Observer => Teacher, Student

            // 5. Stock
            // Subject => Stock{ PriceChange(){changeRate>3%}; Join(){}; Notify(){}}
            // Observer => StockHolders{}

            Console.ReadLine();
        }
        static void Handler(object sender, EventArgs e){
            System.Console.WriteLine("数据输入结束！");
        }
        static void HandlerMore(object sender, EventArgs e){
            System.Console.WriteLine("真的结束了！");
        }
    }
}
