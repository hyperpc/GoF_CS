using System;
using Microsoft.Extensions.Caching.Memory;

namespace ch13_Proxy.SearchAPI
{
    public class SearchCacheProxy : ISearcher
    {
        private IMemoryCache _memoryCache;
        public SearchCacheProxy(IMemoryCache cache){
            _memoryCache = cache;
        }
        private static readonly int cacheTimeoutInMints = 30;
        private static readonly bool enableCaching = true;

        private RealSearcher searcher = new RealSearcher();
        private AccessValidator validator;
        private Logger logger;
        public string DoSearch(string userId, string keyword){
            var rs = string.Empty;
            if(this.Validate(userId)){
                if(enableCaching){
                    if(!_memoryCache.TryGetValue(userId, out rs)){
                        //new cache, set sliding expirate time in 30 mints
                        rs= "hulk's search result in memory cache";
                        _memoryCache.Set(userId, rs
                            , new MemoryCacheEntryOptions().SetSlidingExpiration(TimeSpan.FromMinutes(cacheTimeoutInMints)));
                                System.Console.WriteLine("Add new memory cache. key: {0}, value: {1}.", userId, rs);
                        this.Log(userId);
                    }else{
                        System.Console.WriteLine("Get search result '{0}' from memory cache.", rs);
                        this.Log(userId);
                    }
                }else{
                    SearchAPI.ISearcher searcher = new ProxySearcher();
                    rs = searcher.DoSearch("Hulk", "gamma");
                }
            }else{
                rs=null;
            }
            return rs;
        }
        
        private bool Validate(string userId){
            validator = new AccessValidator();
            return validator.Validate(userId);
        }

        private void Log(string userId){
            logger = new Logger();
            logger.Log(userId);
        }
    }
}