namespace ch12_Flyweight.Extrinsic
{
    public class Coordinates
    {
        private int cx;
        private int cy;
        public Coordinates(int x, int y){
            cx=x;
            cy=y;
        }
        public int X
        {
            get{return cx;}
        }
        public int Y 
        {
            get{return cy;}
        }
    }
}