using System;

namespace ch06_Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Server load balance
            {
                var balancer1 = SLB.LoadBalancer.GetInstance();
                var balancer2 = SLB.LoadBalancer.GetInstance();
                var balancer3 = SLB.LoadBalancer.GetInstance();
                var balancer4 = SLB.LoadBalancer.GetInstance();
                if(balancer1==balancer2 && balancer2==balancer3 && balancer3==balancer4){
                    System.Console.WriteLine("Server Load Balancer is unique");
                }else{
                    System.Console.WriteLine("Server Load Balancer is not unique");
                }

                balancer1.AddServer("Server 1");
                balancer1.AddServer("Server 2");
                balancer1.AddServer("Server 3");
                balancer1.AddServer("Server 4");

                for (int i = 0; i < 10; i++)
                {
                    var server = balancer1.GetServer();
                    System.Console.WriteLine("Send {0} request to: {1}", i+1, server);
                }
            }

            // Exercise 1. MDI，toolbar-singleton

            // Exercise 2. DbConnectionPool - instance, DbConnections-5 connections(random to pick connection)

            Console.ReadKey();
        }
    }
}
