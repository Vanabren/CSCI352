// Name: Vance Brender-A-Brandis
// Date: 2/7/23
// Desc: Teddy Bear child class that inherits and overloads ToyBear interface

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW5_Adapter_Practice
{
    internal class TeddyBear : IToyBear
    {
        // Overloaded printing function to describe wholesome Teddy Bear hugging
        public void hug()
        {
            Console.WriteLine("The Bear gives a warm hug!");
        }
    }
}
