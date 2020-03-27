namespace ch03_AbstractFactory.Themes
{
    public class SummerTextbox : ITextbox
    {
        public void Show(){
            System.Console.WriteLine("Show Summer Textbox");
        }
    }
}