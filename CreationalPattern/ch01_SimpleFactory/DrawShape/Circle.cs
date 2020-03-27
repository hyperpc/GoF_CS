namespace ch01_SimpleFactory.DrawShape
{
    public class Circle : IShape
    {
        public void Draw(){
            System.Console.WriteLine("Draw a circle");
        }

        public void Erase(){
            System.Console.WriteLine("Erase shape");
        }
    }
}