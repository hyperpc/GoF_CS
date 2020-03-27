namespace ch03_AbstractFactory.Themes
{
    public interface ISkinFactory
    {
         IButton CreateButton();
         ITextbox CreateTextbox();
    }
}