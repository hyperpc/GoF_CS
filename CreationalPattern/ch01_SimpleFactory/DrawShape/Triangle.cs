namespace ch01_SimpleFactory.DrawShape
{
    public class Triangle : IShape
    {
        public void Draw(){
            System.Console.WriteLine("Draw a triangle");
        }

        public void Erase(){
            System.Console.WriteLine("Erase shape");
        }
    }
}