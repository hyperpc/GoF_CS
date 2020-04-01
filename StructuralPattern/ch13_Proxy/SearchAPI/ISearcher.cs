namespace ch13_Proxy.SearchAPI
{
    public interface ISearcher
    {
         string DoSearch(string userId, string keyword);
    }
}