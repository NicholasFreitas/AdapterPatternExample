using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterExample
{
    class Program
    {
        static void Main(string[] args)
        {
            //The two things we want to adapt
            var prospect = new Prospect();
            var customer = new Customer();

            //here's their different behavior, two method signatures and thus, two different interfaces
            prospect.ShowProspectName("John Smith");
            customer.ShowCustomerName("John", "Smith");

            //now we use the adapter to call the customer, BUT we use the signature of the prospect.
            var prospToCusAdapter = new ProsToCusAdapter(customer); //<-- we pass in the customer, because that's what we're adapting
            prospToCusAdapter.ShowProspectName("John Smith"); //<--- we call the prospect method, but we will see the customer formatting.
            
            //we essentially adapter the signature of the prospect to the signature of the customer.

        }
    }
}
