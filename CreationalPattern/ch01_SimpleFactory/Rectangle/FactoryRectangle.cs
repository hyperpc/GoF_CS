namespace ch01_SimpleFactory.Rectangle
{
    public class FactoryRectangle
    {
        public static Rectangle CreateRectangle(int width, int length){
            System.Console.WriteLine("Create Rectangle from factory");
            return new Rectangle(width, length);
        }
        public static Rectangle CreateSquare(int width){
            System.Console.WriteLine("Create Square from factory");
            return new Rectangle(width);
        }
    }
}