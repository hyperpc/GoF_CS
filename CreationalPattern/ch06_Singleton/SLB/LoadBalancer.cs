using System;
using System.Collections.Generic;
namespace ch06_Singleton.SLB
{
    public class LoadBalancer
    {
        private static LoadBalancer _INSTANCE = null;
        // when loading class, create one static readonly assist object 
        private static readonly object syncRoot = new object();
        private List<string> Servers = null;

        private LoadBalancer(){
            Servers = new List<string>();
        }

        // Double-check locking
        public static LoadBalancer GetInstance(){
            // 1st check: check if existing. if not, add lock to process
            if(_INSTANCE==null){
                // add lock, only allow one thread to access instance
                lock(syncRoot){
                    // 2nd check: if not eixsting, create new instance
                    if(_INSTANCE==null){
                        _INSTANCE = new LoadBalancer();
                    }
                }
            }
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