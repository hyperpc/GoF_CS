namespace ch03_AbstractFactory.MobileGame
{
    public interface IPlatform
    {
         IOperation OperationControl();
         IUserInterface UIControl();
    }
}