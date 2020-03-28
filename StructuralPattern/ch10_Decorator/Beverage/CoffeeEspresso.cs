namespace ch10_Decorator.Beverage
{
    public class CoffeeEspresso : Coffee
    {
        public override string GetName(){
            return "Espresso(25)";
        }
        public override int GetPrice(){
            return 25;
        }
    }
}