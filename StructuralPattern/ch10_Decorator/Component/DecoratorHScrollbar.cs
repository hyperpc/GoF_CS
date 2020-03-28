namespace ch10_Decorator.Component
{
    public class DecoratorHScrollbar : DecoratorUI
    {
        public DecoratorHScrollbar(UIComponent component) : base(component){

        }
        public override void Display(){
            base.Display();
        }
        public void SetScrollbar(){
            System.Console.WriteLine("Set scroll bar in semi-transparent");
        }
    }
}