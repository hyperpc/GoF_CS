using System.Text;
using System;

namespace ch10_Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Component: in transparent and semi-transparent
            {
                /*
                Component.UIComponent form = new Component.UIForm();
                Component.UIComponent formWithSb = new Component.DecoratorVScrollbar(form);
                Component.UIComponent formWithBb = new Component.DecoratorBlackBorder(formWithSb);
                formWithBb.Display();

                Component.UIComponent tBox = new Component.UITextbox();
                Component.UIComponent tbWithBb = new Component.DecoratorBlackBorder(tBox);
                Component.DecoratorHScrollbar tbWithHsb = new Component.DecoratorHScrollbar(tbWithBb);
                tbWithHsb.SetScrollbar();
                tbWithHsb.Display();
                */
            }

            // Exercise 1. MobilePhone(Ring()), JarPhone(override Ring(), Jar()), ComplexPhone(override Ring(), Lighting())
            //    Define: Phone.cs(abstract void Ring()) ->MobilePhone.cs(override void Ring())
            //            DecoratorJar.cs(override void Ring(), void Jar())
            //            DecoratorLighting.cs(override void Ring(), void Jar())

            // Exercise 2. Beverage(abstract string GetDescription(), abstract int GetCost())
            //    Define: Coffee.cs(abstract string GetName(), abstract int GetPrice())
            //              ->CoffeeEspresso.cs(override string GetName(), override int GetPrice())
            //              ->CoffeeHouseBlend.cs(override string GetName(), override int GetPrice())
            //              ->CoffeeDarkRoast.cs(override string GetName(), override int GetPrice())
            //              ->DecoratorRecipe.cs(override string GetName(), override int GetPrice())
            //              ->RecipeMocha.cs(override string GetName(), override int GetPrice())
            //              ->RecipeWhip.cs(override string GetName(), override int GetPrice())
            //              ->RecipeMilk.cs(override string GetName(), override int GetPrice())
            {
                Beverage.Coffee espresso = new Beverage.CoffeeEspresso();
                Beverage.Coffee mocha = new Beverage.RecipeMocha(espresso);
                Beverage.Coffee milk = new Beverage.RecipeMilk(mocha);
                System.Console.WriteLine("Beverage: {0}, Price: {1}", milk.GetName(), milk.GetPrice());
            }

            // Exercise 3. Encryption
            //    Define: Data(abstract string Encrypt())
            //            PlainData:Data(override string Encrypt())
            
            //            Encryption:Data(override string Encrypt())
            //            Translocation:Encryption(override string Encrypt())
            //            Reversion:Encryption(override string Encrypt())
            //            Modulo:Encryption(override string Encrypt())

            Console.ReadKey();
        }
    }
}
