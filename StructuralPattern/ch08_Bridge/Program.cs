using System;
using System.Configuration;
using System.Reflection;
//dotnet add package System.Configuration.ConfigurationManager --version 4.7.0
namespace ch08_Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Image (matrix) show on diff platform os
            {
                /*
                var imageStr = ConfigurationManager.AppSettings["image"];
                var image = (ImageMatrix.AImage)Assembly.Load("ch08_Bridge").CreateInstance(imageStr);
                var osStr = ConfigurationManager.AppSettings["platform"];
                var os = (ImageMatrix.IPlatformOS)Assembly.Load("ch08_Bridge").CreateInstance(osStr);
                image.SetPlatform(os);
                image.ParseImage("China Map");
                */
            }

            // Exercise 1. Plane: IPlaneBuilder(BuildPlane)-Airbus, Boeing; AbstractPlane(setbuilder, fly)-passenger, cargo
            {
                /*
                var airbusbuilder = new Plane.AirbusBuilder();
                var passengerPlane= new Plane.PassengerPlane();
                airbusbuilder.BuildPlane();
                passengerPlane.SetBuilder(airbusbuilder);
                passengerPlane.Fly();

                var boeingbuilder = new Plane.BoeingBuilder();
                var cargoPlane = new Plane.CargoPlane();
                boeingbuilder.BuildPlane();
                cargoPlane.SetBuilder(boeingbuilder);
                cargoPlane.Fly();
                */
            }
            {
                // PlaneB: APlaneBuilder(iplane, setplane, build)-airbus, boeing; IPlane(fly)-passengerplane, cargoplane
                var airbusBuilder = new PlaneB.AirbusBuilder();
                var passengerPlane = new PlaneB.PassengerPlane();
                airbusBuilder.SetPlane(passengerPlane);
                airbusBuilder.Build();

                var boeingBuilder = new PlaneB.BoeingBuilder();
                var cargoPlane = new PlaneB.CargoPlane();
                boeingBuilder.SetPlane(cargoPlane);
                boeingBuilder.Build();
            }

            // Exercise 2. Data converter: IDb(Connect)-Oracle, MySql, AbstractFileType AFile(protected IDb, SetDB(IDb), Save)-Txt, Xml, Pdf

            // Addition 3. data report and data file: using Bridge and Adapter
            {
                /*
                var chart = new Report.barChart();
                var file = new Report.TxtFile();
                chart.SetData(file);
                chart.Show();
                file.Save();

                var api = new Report.ExcelAPI();
                var adapter = new Report.ExcelAdapter(api, file);
                adapter.Save();
                */
            }

            Console.ReadKey();
        }
    }
}
