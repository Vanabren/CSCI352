// Name: Vance Brender-A-Brandis
// Date: 2/7/2023
// Desc: Adapter to allow the IBear interface to be used by the client (which expects the IToyBear interface)

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace CW5_Adapter_Practice
{
    internal class BearAdapter : IToyBear
    {
        private IBear bear;

        // Parameterized constructor for setting internal bear variable
        // to argued IBear object.
        public BearAdapter(IBear bear)
        {
            this.bear = bear;
        }

        // The adapter turns its hug function to actually perform the
        // maul function from the IBear interface
        public void hug()
        {
            bear.maul();
        }


    }
}
