namespace ch08_Bridge.Plane
{
    public class PassengerPlane : APlane
    {
        public override void Fly(){
            System.Console.WriteLine("This is a passanger plane.");
        }
    }
}