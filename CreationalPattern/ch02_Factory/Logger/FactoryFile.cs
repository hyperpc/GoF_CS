namespace ch02_Factory.Logger
{
    public class FactoryFile : IFactoryLogger
    {
        public ILogger InitLogger(){
            var logger = new FileLogger();
            return logger;
        }
        public ILogger InitLogger(string filepath){
            System.Console.WriteLine("FilePath: " + filepath);
            var logger = new FileLogger();
            return logger;
        }
    }
}