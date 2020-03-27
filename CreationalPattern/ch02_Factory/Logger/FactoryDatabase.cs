namespace ch02_Factory.Logger
{
    public class FactoryDatabase : IFactoryLogger
    {
        public ILogger InitLogger(){
            var logger = new DatabaseLogger();
            return logger;
        }

        public ILogger InitLogger(string connectionString){
            System.Console.WriteLine("ConnectString: " + connectionString);
            var logger = new DatabaseLogger();
            return logger;
        }
    }
}