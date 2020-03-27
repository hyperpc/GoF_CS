namespace ch01_SimpleFactory.Chart
{
    public class ChartHistogram : IChart
    {
        public ChartHistogram(){
            System.Console.WriteLine("Create Histogram");
        }
        public void Display(){
            System.Console.WriteLine("Display Histogram");
        }
    }
}