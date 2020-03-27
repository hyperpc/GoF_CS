namespace ch01_SimpleFactory.Rectangle
{
    public class Rectangle : IRectangle
    {
        private int WIDTH{get;}
        private int LENGTH{get;}
        public Rectangle(int width, int length){
            System.Console.WriteLine("Create Rectangle");
            System.Console.WriteLine(" > WIDTH: " + width);
            System.Console.WriteLine(" > LENGTH: " + length);
            WIDTH = width;
            LENGTH = length;
        }
        
        public Rectangle(int width){
            System.Console.WriteLine("Create Rectangle");
            System.Console.WriteLine(" > WIDTH: " + width);
            WIDTH = width;
            LENGTH = width;
        }

        public void Area(){
            System.Console.WriteLine(" > Area: " + WIDTH * LENGTH);
        }
    }
}