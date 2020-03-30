namespace ch10_Decorator.Component
{
    public class DecoratorBlackBorder : DecoratorUI
    {
        public DecoratorBlackBorder(UIComponent component) : base(component){

        }
        public override void Display(){
            this.SetBlackBorder();
            base.Display();
        }
        private void SetBlackBorder(){
            System.Console.WriteLine("Set black order in transparent");
        }
    }
}