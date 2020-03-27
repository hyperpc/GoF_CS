namespace ch03_AbstractFactory.Themes
{
    public class SpringButton : IButton
    {
        public void Show(){
            System.Console.WriteLine("Show Spring Button");
        }
    }
}