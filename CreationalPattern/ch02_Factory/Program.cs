using System.IO;
using System.Reflection;
using System;
using System.Configuration;
//dotnet add package System.Configuration.ConfigurationManager --version 4.7.0

namespace ch02_Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Factory
            {
                /*
                Logger.IFactoryLogger factory = new Logger.FactoryFile();
                Logger.ILogger logger = factory.InitLogger();
                logger.WriteLog();
                */
            }
            // 2. Factory + Reflection
            {
                /*
                var factoryStr = ConfigurationManager.AppSettings["factory"];
                var factory = (Logger.IFactoryLogger)Assembly.Load("ch02_Factory").CreateInstance(factoryStr);
                var logger = factory.InitLogger();
                logger.WriteLog();
                */
            }
            // 3. Factory + Refactoring
            {
                /*
                Logger.IFactoryLogger factory = new Logger.FactoryFile();
                Logger.ILogger logger = factory.InitLogger("myDir");
                logger.WriteLog();
                */
            }
            // 4. Factory Adv : consumer only need to call factory.API, 
            //                  as business logic was called in factory
            {
                /*
                Logger_Adv.IFactoryLogger factory = new Logger_Adv.FactoryDatabase();
                factory.WriteLog();
                factory.WriteLog("myDir");
                */
            }
            // Exercise 1 : Bank(CreateAccount), abstract Account(Checking, Saving), Client
            // Exercise 2 : ICar(BMW, Benz), IFactory(BMWFactory, BenzFactory)
            // Exercise 3 : IChart(Pie, Line), IFactory(PieFactory, LineFactory)
            // Exercise 4 : IImage(Gif, Jpg, Png), IFactory(GifFactory, JpgFactory, PngFactory)
            // Exercise 5 : IData(Txt, Database, Excel, Json), IFactory(TxtFactory, DatabaseFactory, Excelfactory, JsonFactory)
            //Convert data source to XML
            {
                var factoryTxt = new XmlConverter.FactoryTxt();
                var converter = factoryTxt.InitConverter();
                converter.Convert();

                var factoryJson = new XmlConverter.FactoryJson();
                factoryJson.Convert();
            }

            Console.Read();
        }
    }
}
