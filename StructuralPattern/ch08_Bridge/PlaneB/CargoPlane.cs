namespace ch08_Bridge.PlaneB
{
    public class CargoPlane : IPlane
    {
        public void Fly(){
            System.Console.WriteLine("This is a cargo plane.");
        }
    }
}