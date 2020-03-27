namespace ch03_AbstractFactory.Machien
{
    public interface IMachienFactory
    {
         ITV CreateTV();
         IFridge CreateFridge();
    }
}