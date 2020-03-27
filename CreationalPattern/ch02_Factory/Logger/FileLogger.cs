namespace ch02_Factory.Logger
{
    public class FileLogger : ILogger
    {
        public void WriteLog(){
            System.Console.WriteLine("Write file logger");
        }
    }
}