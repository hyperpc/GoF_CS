using System;
namespace ch20_Observer.DelegateEvent
{
    public class EventTest
    {
        public delegate void UserInput(object sender, EventArgs e);
        public event UserInput OnUserInput;
        public void Method(){
            var flag = false;
            System.Console.WriteLine("Plz input a number:");
            while(!flag){
                if(Console.ReadLine()=="0"){
                    OnUserInput(this, new EventArgs());
                }
            }
        }
    }
}