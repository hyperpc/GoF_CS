namespace ch02_Factory.Logger
{
    public interface IFactoryLogger
    {
         ILogger InitLogger();
         ILogger InitLogger(string path);
    }
}