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
            Privilage = GetPrivilage(Orders.Sum());
        }

        public static string GetPrivilage(int kol)
        {
            if (kol <= 1) return "Normal";
            else if (kol <= 6) return "Great";
            else return "Boss";
        }
    }
}
