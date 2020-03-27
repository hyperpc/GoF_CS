namespace ch03_AbstractFactory.MobileGame
{
    public class iOSMobile : IPlatform
    {
        public IOperation OperationControl(){
            return new iOSOperation();
        }
        public IUserInterface UIControl(){
            return new iOSUI();
        }
    }
}