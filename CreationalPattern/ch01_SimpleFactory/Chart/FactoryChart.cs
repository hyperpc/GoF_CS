namespace ch01_SimpleFactory.Chart
{
    public class FactoryChart {
        public static IChart GetChart(string type){
            IChart chart = null;
            if(type.Equals("histogram")){
                chart = new ChartHistogram();
                System.Console.WriteLine("Init Histogram");
            }else if(type.Equals("pie")){
                chart = new ChartPie();
                System.Console.WriteLine("Init Pie");
            }else if(type.Equals("line")){
                chart = new ChartLine();
                System.Console.WriteLine("Init Line");
            }

            return chart;
        }
    }
}