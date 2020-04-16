using System.Collections.Generic;

namespace ConsoleApp1
{
    public class Customers
    {
        public int Id;
        public string Name;
        public readonly List<Order> Orders= new List<Order>();
        
        public Customers(int id)
        {
            this.Id = id;

        }
        public Customers(int id, string name)
            :this(id)
        {
            this.Name = name;

        }
        public void Promote()
        {
           // Orders = new List<Order>();
        }
    }
}
