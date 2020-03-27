namespace ch03_AbstractFactory.Machien
{
    public class HisenseFridge : IFridge
    {
        public void Freeze(){
            System.Console.WriteLine("Freezingg Hisense fridge");
        }
    }
}