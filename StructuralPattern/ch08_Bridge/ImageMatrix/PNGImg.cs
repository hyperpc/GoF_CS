namespace ch08_Bridge.ImageMatrix
{
    public class PNGImg : AImage
    {
        public override void ParseImage(string filepath){
            Matrix m = new Matrix();
            platform.DoPaint(m);
            System.Console.WriteLine(" {0}, image file type is PNG.", filepath);
        }
    }
}