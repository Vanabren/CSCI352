// Name: Vance Brender-A-Brandis
// Date: 2/7/23
// Desc: Grizzly child class that inherits and overloads Bear interface

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW5_Adapter_Practice
{
    internal class Grizzly : IBear
    {
        // Overloading printing function to describe Grizzly Bear violence
        public void maul()
        {
            Console.WriteLine("The Bear tears apart a victim!");
        }

        // Overloading printing function to describe Grizzly Bear sleeptime
        public void hibernate()
        {
            Console.WriteLine("The Bear sleeps the winter away!");
        }
    }
}
