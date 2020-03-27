namespace ch05_Prototype.ShallowClone
{
    public class WeeklyLog
    {
        public Attachment LogAttachment{get;set;}
        public string Name{get;set;}
        public string Date{get;set;}
        public string Content{get;set;}

        public WeeklyLog Clone(){
            return this.MemberwiseClone() as WeeklyLog;
        }
    }
}