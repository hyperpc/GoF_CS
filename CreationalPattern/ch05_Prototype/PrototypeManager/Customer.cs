using System;
namespace ch05_Prototype.PrototypeManager
{
    public class Customer : ICloneable
    {
        public string Name {get;set;}
        public string MobileNo {get;set;}
        public Address Address {get;set;}

        public Customer ShallowClone(){
            return this.MemberwiseClone() as Customer;
        }

        public object Clone(){
            var copy = this.MemberwiseClone() as Customer;
            var address = new Address{City = (this.Address.City + " Cloned")};
            copy.Address = address;
            return copy;
        }
    }
}