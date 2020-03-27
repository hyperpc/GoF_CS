namespace ch03_AbstractFactory.Machien
{
    public class HaierFactory : IMachienFactory
    {
        //public HaierTV CreateTV(){
        //    return new HaierTV();
        //}

        //public HaierFridge CreateFridge(){
        //    return new HaierFridge();
        //}

        public ITV CreateTV(){
            return new HaierTV();
        }

        public IFridge CreateFridge(){
            return new HaierFridge();
        }
    }
}