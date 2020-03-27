namespace ch08_Bridge.ImageMatrix
{
    public class GIFImg : AImage
    {
        public override void ParseImage(string filepath){
            Matrix m = new Matrix();
            platform.DoPaint(m);
            System.Console.WriteLine(" {0}, image file type is GIF.", filepath);
        }
    }
}