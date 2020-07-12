using System.Reflection;
using System;
using ch24_Visitor.Employee;
using System.Configuration;

//dotnet add package System.Configuration.ConfigurationManager --version 4.7.0
namespace ch24_Visitor
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Employee
            {
                EmployeeList list = new EmployeeList();
                Employee.Employee fte1, fte2,fte3,pte1,pte2;
                fte1 = new FulltimeEmployee("张无忌", 3200.00,45); 
                fte2 = new FulltimeEmployee("杨过", 2000.00,40); 
                fte3 = new FulltimeEmployee("段誉", 2400.00,38); 
                pte1 = new ParttimeEmployee("洪七公",80.00,20);
                pte2 = new ParttimeEmployee("郭靖",60.00,18);

                list.AddEmployee(fte1);
                list.AddEmployee(fte2);
                list.AddEmployee(fte3);
                list.AddEmployee(pte1);
                list.AddEmployee(pte2);

                string visitorStr = ConfigurationManager.AppSettings["visitor"];
                Department department =(Department)Assembly.Load("ch24_Visitor").CreateInstance(visitorStr);
                list.Accept(department);
            }

            // 2. Cart
            //    goods
            //    Cashier, Customer
            //    Apple (Weighing, Price), Book(Price)

            // 3. Award Check
            //    Teacher (){ Paper>10=>ResearchAward; Rating>90=>ExcellenceAward}
            //    Student (){ Paper>2=>ResearchAward; AvgScore>90=>ExcellenceAward}

            Console.ReadLine();
        }
    }
}
