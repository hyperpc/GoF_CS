namespace ch08_Bridge.ImageMatrix
{
    public abstract class AImage
    {
        protected IPlatformOS platform;
        public void SetPlatform(IPlatformOS os){
            this.platform = os;
        }

        public abstract void ParseImage(string filepath);
    }
}