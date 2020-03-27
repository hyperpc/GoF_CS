using System;
namespace ch05_Prototype.DeepClone
{
    public class WeeklyLog : ICloneable
    {
        public Attachment LogAttachment{get;set;}
        public string Name{get;set;}
        public string Date{get;set;}
        public string Content{get;set;}

        public object Clone(){
            var copy = this.MemberwiseClone() as WeeklyLog;
            // 1.
            var attachment = new Attachment();
            copy.LogAttachment = attachment;
            // 2. if attachment is clonable?

            return copy;
        }
    }
}