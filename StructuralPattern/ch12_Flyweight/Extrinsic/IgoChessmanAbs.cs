namespace ch12_Flyweight.Extrinsic
{
    public abstract class IgoChessmanAbs
    {
        public abstract string GetColor();
        public void Display(Coordinates coord){
            System.Console.WriteLine("IgonChessman color: {0}, Position: x={1},y={2}", this.GetColor(), coord.X, coord.Y);
        }
    }
}