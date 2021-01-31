using System;
using System.Collections.Generic;
using System.Text;

namespace Classes
{
    class Customer
    {
        //Property - bir özellik tanımlamak
        public int Id { get; set; }
        public string FirstName { get; set; }
        //private string _firtsName; //field tanımlanır
        //public string FirstName 
        //{ 
        //    get { return "Mrs." + _firtsName; }
        //    set { _firtsName = value; } //value = set etmeye çalıştığımız değere karşılık gelir
        //}
        public string LastName { get; set; }
        public string City { get; set; }
    }
}
