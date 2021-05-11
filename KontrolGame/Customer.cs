using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace KontrolGame
{
    public class Customer
    {
        public string Privilage { get; set; }

        public List<int> Orders { get; set; }
        public Customer(List<int> orders)
        {
            Privilage = PrivilageClass.GetPrivilage(orders.Count);
        }
        


    }
}
