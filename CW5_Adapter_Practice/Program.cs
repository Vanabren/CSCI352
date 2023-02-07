// Name: Vance Brender-A-Brandis
// Date: 2/7/23
// Desc: The program acts a client for the Adapter structural design practice

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW5_Adapter_Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Grizzly gBear = new Grizzly();
            TeddyBear tBear = new TeddyBear();
            BearAdapter baBear = new BearAdapter(gBear);

            // Grizzly bear functions
            gBear.hibernate();
            gBear.maul();

            // Teddy bear functions
            tBear.hug();

            // Bear adapter functions
            baBear.hug();
        }
    }
}
