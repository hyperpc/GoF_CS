namespace ch13_Proxy.SearchAPI
{
    public class RealSearcher : ISearcher
    {
        public string DoSearch(string userId, string keyword){
            System.Console.WriteLine("User '{0}' search db using keyword '{1}'.", userId, keyword);
            return "search results";
        }
    }
}