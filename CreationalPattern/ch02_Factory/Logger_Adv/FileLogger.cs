namespace ch02_Factory.Logger_Adv
{
    public class FileLogger : ILogger
    {
        public void WriteLog(){
            System.Console.WriteLine("Write file logger");
        }
    }
}