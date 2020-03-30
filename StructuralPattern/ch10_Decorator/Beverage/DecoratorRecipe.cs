using System;
namespace ch10_Decorator.Beverage
{
    public class DecoratorRecipe : Coffee
    {
        private Coffee coffee;
        public DecoratorRecipe(Coffee coffee){
            this.coffee = coffee;
        }
        public override string GetName(){
            return coffee.GetName();
        }
        public override int GetPrice(){
            return coffee.GetPrice();
        }
    }
}