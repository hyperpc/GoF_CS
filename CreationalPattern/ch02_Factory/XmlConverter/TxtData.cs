namespace ch02_Factory.XmlConverter
{
    public class TxtData : IData
    {
        public void Convert(){
            System.Console.WriteLine("Convert txt data to xml");
        }
    }
}