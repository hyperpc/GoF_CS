using System.Security.AccessControl;
using System;
using ch21_State.BankAccount;
using ch21_State.SwitchDemo;
using ch21_State.Screen;

namespace ch21_State
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Bank Account State
            {
                /*
                Account acc = new Account("段誉",0);
                acc.Deposite(1000);
                acc.Withdraw(2000);
                acc.Deposite(3000);
                acc.Withdraw(4000);
                acc.Withdraw(10000);
                acc.ComputeInterest();
                */
            }

            // 2. Switch Demo
            {
                /*
                Switch s1=new Switch("开关1");
                Switch s2=new Switch("开关2");
                s1.On();
                s2.On();
                s1.Off();
                s2.Off();
                s2.On();
                s1.On();
                */
            }

            // 3. Screen Large
            {
                Screen.Screen screen = new Screen.Screen();
                screen.OnClick();
                screen.OnClick();
                screen.OnClick();
            }

            // 4. Door : Open, Opening, StayOpen, Closing, Closed
            // 5. Blog : newer, advancer, expert
            // 6. CardGame : Primary, Secondary, Professional, Final

            Console.ReadLine();
        }
    }
}
