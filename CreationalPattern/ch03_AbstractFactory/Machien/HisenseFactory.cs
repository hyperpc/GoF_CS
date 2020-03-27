namespace ch03_AbstractFactory.Machien
{
    public class HisenseFactory : IMachienFactory
    {
        public ITV CreateTV(){
            return new HisenseTV();
        }

        public IFridge CreateFridge(){
            return new HisenseFridge();
        }
    }
}