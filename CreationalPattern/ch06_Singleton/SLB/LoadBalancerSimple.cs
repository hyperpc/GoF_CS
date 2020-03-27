using System;
using System.Collections.Generic;

namespace ch06_Singleton.SLB
{
    public class LoadBalancerSimple
    {
        // instance LoadBalancer when loading class, not delay to its constructor
        // not good practice for resource utilization
        private static LoadBalancerSimple _INSTANCE = new LoadBalancerSimple();
        private List<string> Servers = null;

        private LoadBalancerSimple(){
            Servers = new List<string>();
        }

        public static LoadBalancerSimple GetInstance(){
            return _INSTANCE;
        }

        public void AddServer(string server){
            Servers.Add(server);
        }
        public void RemoveServer(string server){
            // should check if eixsting server, then remove at index
            Servers.Remove(server);
        }

        public string GetServer(){
            var random = new Random();
            var i = random.Next(Servers.Count);
            return Servers[i];
        }
    }
}