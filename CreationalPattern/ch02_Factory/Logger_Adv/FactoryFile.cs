namespace ch02_Factory.Logger_Adv
{
    public class FactoryFile : IFactoryLogger
    {
        public override ILogger InitLogger(){
            var logger = new FileLogger();
            return logger;
        }
        public override ILogger InitLogger(string filepath){
            System.Console.WriteLine("FilePath: " + filepath);
            var logger = new FileLogger();
            return logger;
        }
    }
}