namespace ch03_AbstractFactory.Themes
{
    public class SpringTextbox : ITextbox
    {
        public void Show(){
            System.Console.WriteLine("Show Spring Textbox");
        }
    }
}