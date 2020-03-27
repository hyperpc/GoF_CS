namespace ch03_AbstractFactory.Machien
{
    public class HaierFridge : IFridge
    {
        public void Freeze(){
            System.Console.WriteLine("Freezingg Haier fridge");
        }
    }
}