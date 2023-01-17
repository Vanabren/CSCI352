/* Name: Vance Brender-A-Brandis
   Date: 1/17/23
   Brief Desc.: Hello World program in C# 
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW2___CSCI352__Remake_
{
    class Program // change the name of the Class
    {
        private int steve;

        public void setSteve(int s)
        {
            steve = s;
        }

        public int getSteve()
        {
            return steve;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("hello world!");
            // Console.WriteLine("setting steve to + " + 4);
            /*
            Program p = new Program();
            p.setSteve(4);
            Console.WriteLine("Steve is " + p.getSteve());
            Console.ReadKey();
            */
        }
    }
}
