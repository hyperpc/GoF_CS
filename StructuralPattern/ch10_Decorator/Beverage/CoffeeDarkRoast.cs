namespace ch10_Decorator.Beverage
{
    public class CoffeeDarkRoast : Coffee
    {
        public override string GetName(){
            return "Dark Roast(20)";
        }
        public override int GetPrice(){
            return 20;
        }
    }
}