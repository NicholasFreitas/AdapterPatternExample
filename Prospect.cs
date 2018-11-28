using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterExample
{
    class Prospect : IProspect
    {
        public void ShowProspectName(string fullname)
        {
            Console.WriteLine("Prospect Name: " + fullname);
        }
    }
}
