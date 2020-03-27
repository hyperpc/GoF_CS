using System.Collections.Generic;
using Newtonsoft.Json;
using System.Linq;

namespace ch05_Prototype.PrototypeManager
{
    // Douoble-Check locking
    public class CustomerManager
    {
        private static CustomerManager _INSTANCE = null;
        // when loading class, create one static readonly assist object 
        private static readonly object syncRoot = new object();
        private Dictionary<string, Customer> customers = null;

        private CustomerManager(){
            customers = new Dictionary<string, Customer>();
        }

        public void AddCustomer(string key, Customer customer){
            // check if existing same key
            customers.Add(key, customer);
        }
        public void RemoveCustomer(string  key){
            // check if existing the key
            customers.Remove(key);
        }

        public Customer GetCustomer(string key){
            // check if existing the key

            //var copy = (customers[key] as Customer).Clone();

            //var json = customers[key].ToString();
            //var copy = JsonConvert.DeserializeObject<Customer>(json);
            
            var kvCust = customers.Where(c=>c.Key==key).FirstOrDefault();
            var copy = kvCust.Value.Clone() as Customer;
            return copy;
        }

        public static CustomerManager GetManager(){
            if(_INSTANCE==null){
                lock(syncRoot){
                    if(_INSTANCE==null){
                        _INSTANCE = new CustomerManager();
                    }
                }
            }
            return _INSTANCE;
        }

    }
}