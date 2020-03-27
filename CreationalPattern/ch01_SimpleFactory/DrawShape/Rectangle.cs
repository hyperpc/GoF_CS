namespace ch01_SimpleFactory.DrawShape
{
    public class Rectangle : IShape
    {
        public void Draw(){
            System.Console.WriteLine("Draw a rectangle");
        }

        public void Erase(){
            System.Console.WriteLine("Erase shape");
        }
    }
}