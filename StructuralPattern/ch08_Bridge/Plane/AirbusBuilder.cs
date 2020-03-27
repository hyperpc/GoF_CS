namespace ch08_Bridge.Plane
{
    public class AirbusBuilder : IPlaneBuilder
    {
        public void BuildPlane(){
            System.Console.Write("Airbus build a plane: ");
        }
    }
}