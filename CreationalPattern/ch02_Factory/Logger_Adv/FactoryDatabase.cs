namespace ch02_Factory.Logger_Adv
{
    public class FactoryDatabase : IFactoryLogger
    {
        public override ILogger InitLogger(){
            var logger = new DatabaseLogger();
            return logger;
        }

        public override ILogger InitLogger(string connectionString){
            System.Console.WriteLine("ConnectString: " + connectionString);
            var logger = new DatabaseLogger();
            return logger;
        }
    }
}