namespace ch08_Bridge.PlaneB
{
    public class PassengerPlane : IPlane
    {
        public void Fly(){
            System.Console.WriteLine("This is a passanger plane.");
        }
    }
}