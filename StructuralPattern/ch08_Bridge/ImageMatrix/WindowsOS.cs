namespace ch08_Bridge.ImageMatrix
{
    public class WindowsOS : IPlatformOS
    {
        public void DoPaint(Matrix m){
            System.Console.Write("Windows show image: ");
        }
    }
}