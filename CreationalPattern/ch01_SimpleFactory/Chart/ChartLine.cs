namespace ch01_SimpleFactory.Chart
{
    public class ChartLine : IChart
    {
        public ChartLine(){
            System.Console.WriteLine("Create Line");
        }
        public void Display(){
            System.Console.WriteLine("Display Line");
        }
    }
}