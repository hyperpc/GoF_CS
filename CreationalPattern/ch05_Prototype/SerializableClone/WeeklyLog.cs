using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.IO;
using System;

namespace ch05_Prototype.SerializableClone
{
    [Serializable]
    public class WeeklyLog
    {
        public Attachment LogAttachment{get;set;}
        public string Name{get;set;}
        public string Date{get;set;}
        public string Content{get;set;}

        public WeeklyLog Clone(){
            WeeklyLog copy = null;

            try{
                using(var fs = new FileStream("temp.dat", FileMode.Create)){
                    BinaryFormatter formatter = new BinaryFormatter();
                    formatter.Serialize(fs, this);
                }
            }catch(SerializationException ex){
                System.Console.WriteLine("Failed to serialized: {0}", ex.Message);
            }finally{
            }

            try{
                using(var fs = new FileStream("temp.dat", FileMode.Open)){
                    BinaryFormatter formatter = new BinaryFormatter();
                    copy = formatter.Deserialize(fs) as WeeklyLog;
                }
            }catch(SerializationException ex){
                System.Console.WriteLine("Failed to deserialized: {0}", ex.Message);
            }finally{
            }
            return copy;
        }
    }
}