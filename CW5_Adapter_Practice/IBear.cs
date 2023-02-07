// Name: Vance Brender-A-Brandis
// Date: 2/7/23
// Desc: Bear interface to be inherited in future concrete classes

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW5_Adapter_Practice
{
    internal interface IBear
    {
        // abstract function for printing a description of bear violence
        void maul();

        // abstract function for printing a description of long periods of bear sleep
        void hibernate();
    }
}
