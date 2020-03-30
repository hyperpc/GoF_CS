using System.Reflection;
using System;
using System.Configuration;
//dotnet add package System.Configuration.ConfigurationManager --version 4.7.0
namespace ch10_Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Facade
            {
                /*
                EncryptFacade facade = new EncryptFacade();
                facade.FileEncrypt("src.txt", "des.txt");
                */
            }

            // 2. Abstract Facade
            {
                var facadeStr = ConfigurationManager.AppSettings["facade"];
                var facade =(EncryptExt.AbstractEncryptFacade)Assembly.Load("ch10_Facade").CreateInstance(facadeStr);
                facade.FileEncrypt("src.txt","des.txt");
            }

            // Exercise 1. Report
            //  Define: AbstractFacade(+ShowReport())
            //          ReportFacade(-reader, +ShowReport())
            //          ReportExtFacade(-reader, -converter, +ShowReport())
            //          FileReader()
            //          FileConverter()


            // Exercise 2. Host
            //  Define: Mainframe(+On())
            //          Memory(bool Check())
            //          CPU(bool Run())
            //          Disk(bool Read())
            //          OS(bool Load())

            // Exercise 3. OnekeyBackup
            //  Define: MobilePhone(Backup)
            //          Contactor(Copy())
            //          Message(Copy())
            //          Gallary(Copy())
            //          Songs(Copy())


            Console.ReadKey();
        }
    }
}
