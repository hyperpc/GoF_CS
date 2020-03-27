using System;

using System.Configuration;
//dotnet add package System.Configuration.ConfigurationManager --version 4.7.0

namespace ch01_SimpleFactory
{
    class Program {
        static void Main(string[] args) {
            {
            /*
            // Sample 1
            //histogram, pie, line
            Chart.IChart chart = Chart.FactoryChart.GetChart("histogram"); 
            chart.Display();

            // move charttype to config file
            var configType=ConfigurationManager.AppSettings["chartType"];
            if(string.IsNullOrWhiteSpace(configType)){
                configType = "histogram";
            }
            Chart.IChart chartConfig = Chart.FactoryChart.GetChart(configType); 
            chartConfig.Display();
            */
            }
            {
            /*
            // Sample 2
            // Diff Rectangle and factoryRectangle
            var nonFriendly_Rectangle = new Rectangle.Rectangle(2,3);// create rectagnle
            nonFriendly_Rectangle.Area();
            var nonFriendly_Square = new Rectangle.Rectangle(2);// create square
            nonFriendly_Square.Area();

            var friendly_Rectangle = Rectangle.FactoryRectangle.CreateRectangle(2,3);// create rectagnle
            friendly_Rectangle.Area();
            var friendly_Square = Rectangle.FactoryRectangle.CreateSquare(2);// create square
            friendly_Square.Area();
            */
            }

            // sample 3: DBO - Oracle, SqlServer

            {
                /*
                // Exercise 1
                // Person
                var person = Person.Nvwa.Generate(null);
                person.Talk();
                person = Person.Nvwa.Generate("M");
                person.Talk();
                */
            }
            {
                // Exercise 2
                // Draw Shape
                var shape = DrawShape.FactoryDraw.Draw(null);
                shape = DrawShape.FactoryDraw.Draw("Square");
                shape = DrawShape.FactoryDraw.Draw("rectangle");
            }

            Console.Read();
        }
    }
}
