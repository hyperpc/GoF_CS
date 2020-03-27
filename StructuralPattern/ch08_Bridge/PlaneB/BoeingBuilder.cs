namespace ch08_Bridge.PlaneB
{
    public class BoeingBuilder : APlaneBuilder
    {
        public override void Build(){
            System.Console.Write("Boeing build a plane: ");
            plane.Fly();
        }
    }
}