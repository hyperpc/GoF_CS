using System.Reflection;
using System;
using System.Configuration;

//dotnet add package System.Configuration.ConfigurationManager --version 4.7.0
namespace ch04_Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Actor
            {
                /*
                var buildertype = ConfigurationManager.AppSettings["builder"];
                var builder = (GameOnLine.ABuilder)Assembly.Load("ch04_Builder").CreateInstance(buildertype);
                var actorCtrl = new GameOnLine.ActorController();
                var actor = actorCtrl.Construct(builder);
                System.Console.WriteLine("Actor: {0}", actor.Type);
                System.Console.WriteLine("  >>Gender: {0}", actor.Gender);
                System.Console.WriteLine("  >>Face: {0}", actor.Face);
                System.Console.WriteLine("  >>Costume: {0}", actor.Costume);
                System.Console.WriteLine("  >>HairStyle: {0}", actor.HairStyle);
                */
            }
            // 2. Actor: move Construct() to ABuilder(): not recommend
            {
                /*
                var buildertype = ConfigurationManager.AppSettings["builder"];
                var builder = (GameOnLineAdv.ABuilder)Assembly.Load("ch04_Builder").CreateInstance(buildertype);
                //var actor = GameOnLineAdv.ABuilder.Construct(builder);
                var actor = builder.Construct();
                System.Console.WriteLine("Actor: {0}", actor.Type);
                System.Console.WriteLine("  >>Gender: {0}", actor.Gender);
                System.Console.WriteLine("  >>Face: {0}", actor.Face);
                System.Console.WriteLine("  >>Costume: {0}", actor.Costume);
                System.Console.WriteLine("  >>HairStyle: {0}", actor.HairStyle);
                */
            }

            // 3. Actor: Devil - with hook method
            {
                /*
                var builder = new GameOnLineAdv.DevilBuilder();
                var actorCtrl = new GameOnLineAdv.ActorController();
                var actor = actorCtrl.Construct(builder);
                System.Console.WriteLine("Actor: {0}", actor.Type);
                System.Console.WriteLine("  >>Gender: {0}", actor.Gender);
                System.Console.WriteLine("  >>Face: {0}", actor.Face);
                System.Console.WriteLine("  >>Costume: {0}", actor.Costume);
                System.Console.WriteLine("  >>HairStyle: {0}", actor.HairStyle);
                */
            }
            // Exercise 1. Computer
            {
                var computerCtrl = new Computer.ComputerController();
                var pcbuilder = new Computer.PCBuilder();
                var pc = computerCtrl.Construct(pcbuilder);
                System.Console.WriteLine("PC:");
                System.Console.WriteLine("  >>CPU: {0}", pc.CPU);
                System.Console.WriteLine("  >>Memory: {0}", pc.Memory);
                System.Console.WriteLine("  >>Disk: {0}", pc.Disk);
                System.Console.WriteLine("  >>Host: {0}", pc.Host);
                System.Console.WriteLine("  >>Display: {0}", pc.Display);
                var svcBuilder= new Computer.ServerBuilder();
                var server = computerCtrl.Construct(svcBuilder);
                System.Console.WriteLine("Server:");
                System.Console.WriteLine("  >>CPU: {0}", server.CPU);
                System.Console.WriteLine("  >>Memory: {0}", server.Memory);
                System.Console.WriteLine("  >>Disk: {0}", server.Disk);
                System.Console.WriteLine("  >>Host: {0}", server.Host);
                System.Console.WriteLine("  >>Display: {0}", server.Display);
            }

            //Exercise 2. player: 
            //  playerCtrl -Construct(builder), 
            //  player -windows,controlBar,menu,playlist,favlist,
            //  playerModel -ShowWindows(), Show...
            //  FullModel-all, Basic-windows,ctrlBar, MemoryModel-windows,ctrlbar,favlist, OnlineModel-...

            Console.ReadKey();
        }
    }
}
