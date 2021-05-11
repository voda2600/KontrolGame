using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace KontrolGame
{
    public class Order
    {
        public int NumberOfProd { get; }
        public string  PrivilageOfOrder{get;}

        public Customer _customer;
        public Order (int kol, Customer customer)
        {
            _customer = customer;
            NumberOfProd = kol;
            PrivilageOfOrder = Customer.GetPrivilage(_customer.Orders.Sum() + NumberOfProd);
        }


        public int PercentOfSale()
        {
           
            if (PrivilageOfOrder == "Great") return 10;
            else if (PrivilageOfOrder == "Boss") return 20;
            else return 0;
        }

    }
}
