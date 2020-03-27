namespace ch08_Bridge.ImageMatrix
{
    public class LinuxOS : IPlatformOS
    {
        public void DoPaint(Matrix m){
            System.Console.Write("Linux show image: ");
        }
    }
}