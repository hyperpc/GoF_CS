namespace ch13_Proxy.SearchAPI
{
    public class Logger
    {
        public void Log(string userId){
            System.Console.WriteLine("Update Db. User '{0}' search count added 1!", userId);
        }
    }
}