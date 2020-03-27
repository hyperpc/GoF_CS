using System.Net.Mail;
using System;

namespace ch05_Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Shallow Clone
            {
                /*
                System.Console.WriteLine("Shallow Clone");
                var log_pre = new ShallowClone.WeeklyLog();
                var attachment = new ShallowClone.Attachment();
                log_pre.LogAttachment=attachment;

                var log_new = log_pre.Clone();

                System.Console.WriteLine("Is Same WeeklyLog? >> {0}", log_new.Equals(log_pre)?"Yes":"No");
                System.Console.WriteLine("Is Same Attachment? >> {0}", log_new.LogAttachment.Equals(log_pre.LogAttachment)?"Yes":"No");
                */
            }

            // 2. Deep Clone
            {
                /*
                System.Console.WriteLine("Deep Clone");
                var log_pre = new DeepClone.WeeklyLog();
                var attachment = new DeepClone.Attachment();
                log_pre.LogAttachment=attachment;

                var log_new = log_pre.Clone() as DeepClone.WeeklyLog;

                System.Console.WriteLine("Is Same WeeklyLog? >> {0}", log_new.Equals(log_pre)?"Yes":"No");
                System.Console.WriteLine("Is Same Attachment? >> {0}", log_new.LogAttachment.Equals(log_pre.LogAttachment)?"Yes":"No");
                */
            }

            // 3. Serializable Deep Clone
            {
                /*
                System.Console.WriteLine("Serializable Deep Clone");
                var log_pre = new SerializableClone.WeeklyLog();
                var attachment = new SerializableClone.Attachment();
                log_pre.LogAttachment=attachment;

                var log_new = log_pre.Clone();

                System.Console.WriteLine("Is Same WeeklyLog? >> {0}", log_new.Equals(log_pre)?"Yes":"No");
                System.Console.WriteLine("Is Same Attachment? >> {0}", log_new.LogAttachment.Equals(log_pre.LogAttachment)?"Yes":"No");
                */
            }

            // Exercise 1. DataChart, dataset(date, number, remark), id, color
            // Exercise 2. DocumentManager, templateList, template, id, header, title, content, footer
            // Exercise 3. CustomerManager, customerList, customer, name, mobileno, address(country, city)
            {
                // Prototype Manager
                var manager = PrototypeManager.CustomerManager.GetManager();
                var custA = new PrototypeManager.Customer{Name = "CustA"};
                var address = new PrototypeManager.Address{Country="China", City = "Chengdu"};
                custA.Address = address;
                var custB = custA.ShallowClone(); // Shallow Clone
                custB.Name = "CustB";
                System.Console.WriteLine("A is same as B? >> {0}",(custA.Equals(custB)?"Yes": "No"));
                System.Console.WriteLine("A.Address is same as B.Address? >> {0}",(custA.Address.Equals(custB.Address)?"Yes": "No"));
                System.Console.WriteLine("A.Name={0}", custA.Name);
                System.Console.WriteLine("A.Address.City={0}",custA.Address.City);
                System.Console.WriteLine("B.Name={0}", custB.Name);
                System.Console.WriteLine("B.Address.City={0}",custB.Address.City);

                manager.AddCustomer("A", custA);
                manager.AddCustomer("B", custB);
                var custA_copy = manager.GetCustomer("A"); // Deep Clone
                var custB_copy = manager.GetCustomer("B"); // Deep Clone
                System.Console.WriteLine("A_copy is same as B_copy? >> {0}",(custA_copy.Equals(custB_copy)?"Yes": "No"));
                System.Console.WriteLine("A_copy.Address is same as B_copy.Address? >> {0}",(custA_copy.Address.Equals(custB_copy.Address)?"Yes": "No"));
                System.Console.WriteLine("A_copy.Name={0}", custA_copy.Name);
                System.Console.WriteLine("A_copy.Address.City={0}",custA_copy.Address.City);
                System.Console.WriteLine("B_copy.Name={0}", custB_copy.Name);
                System.Console.WriteLine("B_copy.Address.City={0}",custB_copy.Address.City);
            }

            Console.ReadKey();
        }
    }
}
