namespace ch10_Decorator.Beverage
{
    public class RecipeMocha : DecoratorRecipe
    {
        public RecipeMocha(Coffee coffee):base(coffee){

        }
        public override string GetName(){
            return base.GetName() + " + Mocha(10)";
        }
        public override int GetPrice(){
            return base.GetPrice() + 10;
        }
    }
}