namespace ch10_Decorator.Beverage
{
    public class RecipeMilk : DecoratorRecipe
    {
        public RecipeMilk(Coffee coffee):base(coffee){

        }
        public override string GetName(){
            return base.GetName() + " + Milk(6)";
        }
        public override int GetPrice(){
            return base.GetPrice() + 6;
        }
    }
}