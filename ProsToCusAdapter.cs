using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterExample
{
    class ProsToCusAdapter : IProspectToCustomerAdapter
    {
        ICustomer AdaptedCustomer;

        public ProsToCusAdapter(ICustomer customer)
        {
            AdaptedCustomer = customer;
        }

        public void ShowProspectName(string fullname)
        {
            var processedName = fullname.Split(' ');

            AdaptedCustomer.ShowCustomerName( processedName[0] , processedName[1] );
        }
    }
}
