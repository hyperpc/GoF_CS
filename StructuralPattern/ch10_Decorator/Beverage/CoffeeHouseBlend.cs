namespace ch10_Decorator.Beverage
{
    public class CoffeeHouseBlend : Coffee
    {
        public override string GetName(){
            return "House Blend(30)";
        }
        public override int GetPrice(){
            return 30;
        }
    }
}