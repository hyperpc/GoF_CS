using System.Reflection;
using System;
using System.Configuration;
using ch23_TemplateMethod.BankAccount;
using ch23_TemplateMethod.DataViewer;

//dotnet add package System.Configuration.ConfigurationManager --version 4.7.0
namespace ch23_TemplateMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Bank Account Interest
            {
                /*
                string subClass = ConfigurationManager.AppSettings["subClass"];
                Account account = (Account)Assembly.Load("ch23_TemplateMethod").CreateInstance(subClass);
                account.Handle("hyp","1234");
                */
            }

            // 2. Data Viewer
            {
                DataViewer.DataViewer dv = new DataViewer.XMLDataViewer();
                dv.Process();

                dv = new DataViewer.JsonDataViewer();
                dv.Process();
            }

            // 3. Bank : QueueNo(), DoBiz(), Score() => Deposite(), Withdraw(), Transfer()

            // 4. CRM : 

            Console.ReadLine();
        }
    }
}
