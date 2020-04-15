using System.Collections.Generic;

namespace ConsoleApp2 { 
    public class Customer { 
        
        public int id;
        public string name;
        public List<Order> Orders;

        public Customer()
        {
            Orders = new List<Order>();

        }
        public Customer(int Id)
            : this()
        {
            this.id = Id;
        }
        public Customer(int Id,string Name)
            : this(Id)
        {
            
            this.name = Name;
        }

    }

}




