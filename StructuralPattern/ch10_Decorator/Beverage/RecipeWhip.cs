namespace ch10_Decorator.Beverage
{
    public class RecipeWhip : DecoratorRecipe
    {
        public RecipeWhip(Coffee coffee):base(coffee){

        }
        public override string GetName(){
            return base.GetName() + " + Whip(8)";
        }
        public override int GetPrice(){
            return base.GetPrice() + 8;
        }
    }
}