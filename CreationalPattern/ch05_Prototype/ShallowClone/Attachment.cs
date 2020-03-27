namespace ch05_Prototype.ShallowClone
{
    public class Attachment
    {
        public string Name{get;set;}
        public void Download(){
            System.Console.WriteLine("Downloading attachment: {0}", this.Name);
        }
    }
}