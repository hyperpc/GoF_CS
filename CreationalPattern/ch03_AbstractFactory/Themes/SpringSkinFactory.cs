namespace ch03_AbstractFactory.Themes
{
    public class SpringSkinFactory : ISkinFactory
    {
        public IButton CreateButton(){
            return new SpringButton();
        }

        public ITextbox CreateTextbox(){
            return new SpringTextbox();
        }
    }
}