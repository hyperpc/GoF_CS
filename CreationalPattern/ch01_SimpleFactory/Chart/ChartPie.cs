namespace ch01_SimpleFactory.Chart
{
    public class ChartPie : IChart
    {
        public ChartPie(){
            System.Console.WriteLine("Create Pie");
        }
        public void Display(){
            System.Console.WriteLine("Display Pie");
        }
    }
}