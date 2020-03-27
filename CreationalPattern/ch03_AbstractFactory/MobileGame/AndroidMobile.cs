namespace ch03_AbstractFactory.MobileGame
{
    public class AndroidMobile:IPlatform
    {
        public IOperation OperationControl(){
            return new AndroidOperation();
        }
        public IUserInterface UIControl(){
            return new AndroidUI();
        }
    }
}