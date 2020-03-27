namespace ch02_Factory.Logger_Adv
{
    public abstract class IFactoryLogger
    {
         public abstract ILogger InitLogger();
         public abstract ILogger InitLogger(string path);

         public void WriteLog(){
             var logger = this.InitLogger();
             logger.WriteLog();
         }
         public void WriteLog(string path){
             var logger = this.InitLogger(path);
             logger.WriteLog();
         }
    }
}