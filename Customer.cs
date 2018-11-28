using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterExample
{
    class Customer : ICustomer
    {
        public void ShowCustomerName(string first, string last)
        {
            Console.WriteLine("Customer name: " + first + " " + last);
        }
    }
}
