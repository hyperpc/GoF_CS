using System;
namespace ch10_Decorator.Component
{
    public class UIForm : UIComponent
    {
        public override void Display(){
            System.Console.WriteLine("Display Form");
        }
    }
}