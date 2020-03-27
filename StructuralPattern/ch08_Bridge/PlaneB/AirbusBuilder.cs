namespace ch08_Bridge.PlaneB
{
    public class AirbusBuilder : APlaneBuilder
    {
        public override void Build(){
            System.Console.Write("Airbus build a plane: ");
            plane.Fly();
        }
    }
}