namespace ch13_Proxy.SearchAPI
{
    /// <summary>
    /// Protect Proxy And Smart Reference Proxy
    /// </summary>
    public class ProxySearcher : ISearcher
    {
        private RealSearcher searcher = new RealSearcher();
        private AccessValidator validator;
        private Logger logger;

        public string DoSearch(string userId, string keyword){
            if(this.Validate(userId)){
                var rs = searcher.DoSearch(userId, keyword);
                this.Log(userId);
                return rs;
            }else{
                return null;
            }
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