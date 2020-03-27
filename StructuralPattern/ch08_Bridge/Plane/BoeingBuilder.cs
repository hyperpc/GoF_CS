namespace ch08_Bridge.Plane
{
    public class BoeingBuilder : IPlaneBuilder
    {
        public void BuildPlane(){
            System.Console.Write("Boeing build a plane: ");
        }
    }
}