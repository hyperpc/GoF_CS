namespace ch10_Decorator.Component
{
    public class DecoratorUI : UIComponent
    {
        private UIComponent component;
        public DecoratorUI(UIComponent component){
            this.component = component;
        }
        public override void Display(){
            component.Display();
        }
    }
}