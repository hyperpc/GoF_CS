namespace ch02_Factory.Logger_Adv
{
    public class DatabaseLogger : ILogger
    {
        public void WriteLog(){
            System.Console.WriteLine("Write database logger");
        }
    }
}