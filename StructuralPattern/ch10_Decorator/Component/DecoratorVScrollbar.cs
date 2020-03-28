namespace ch10_Decorator.Component
{
    public class DecoratorVScrollbar : DecoratorUI
    {
        public DecoratorVScrollbar(UIComponent component) : base(component){

        }
        public override void Display(){
            this.SetScrollbar();
            base.Display();
        }
        private void SetScrollbar(){
            System.Console.WriteLine("Set scroll bar in transparent");
        }
    }
}