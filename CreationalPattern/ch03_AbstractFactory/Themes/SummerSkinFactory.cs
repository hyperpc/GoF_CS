namespace ch03_AbstractFactory.Themes
{
    public class SummerSkinFactory:ISkinFactory
    {
        public IButton CreateButton(){
            return new SummerButton();
        }

        public ITextbox CreateTextbox(){
            return new SummerTextbox();
        }
    }
}