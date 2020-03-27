namespace ch08_Bridge.Report
{
    public class TxtFile : IDataFile
    {
        public void Save(){
            System.Console.WriteLine("Save report as txt file.");
        }
    }
}