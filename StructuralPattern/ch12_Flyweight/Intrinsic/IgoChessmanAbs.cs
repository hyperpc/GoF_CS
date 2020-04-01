namespace ch12_Flyweight.Intrinsic
{
    public abstract class IgoChessmanAbs
    {
        public abstract string GetColor();
        public void Display(){
            System.Console.WriteLine("IgonChessman color: " + this.GetColor());
        }
    }
}