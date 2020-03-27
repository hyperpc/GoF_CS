namespace ch08_Bridge.Plane
{
    public class CargoPlane : APlane
    {
        public override void Fly(){
            System.Console.WriteLine("This is a cargo plane.");
        }
    }
}