using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerFormProject
{
    public class Customer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<Purchase> Purchases { get; set; }

        public Customer()
        {
            Purchases = new List<Purchase>();
        }
    }
}
