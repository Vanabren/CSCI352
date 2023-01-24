// Name: Vance Brender-A-Brandis
// Date: 1/24/23
// Description: Hippo child class of Animal superclass and its overrided functions

using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalProgram
{
    internal class Hippo : Animal
    {
        // Parameterized constructor for Hippo child class
        // Purpose: Initializes respective variables to argued values
        public Hippo(string name, int age, float weight) 
        {
            setName(name);
            setAge(age);
            setWeight(weight);
            setNoise("grunt");
        }

        // Overrided makeNoise() function for Hippo child class
        // Purpose: Prints noise the animal makes to the console
        public override void makeNoise()
        {
            Console.WriteLine(getName() + " the Hippo " + getNoise() + "s!");
        }

        // Overrided ageUp() function for Hippo child class
        // Purpose: Ages up the animal by one year
        public override void ageUp()
        {
            setAge(getAge() + 1);
        }

        // Overrided printInfo() function for Hippo child class
        // Purpose: Prints Name, Age, Weight, and the noise the Hippo makes to console
        public override void printInfo()
        {
            Console.WriteLine("* Type: Hippo");
            Console.WriteLine("* Name: " + getName());
            Console.WriteLine("* Age: " + getAge());
            Console.WriteLine("* Weight: " + getWeight());
            Console.WriteLine("* Noise: " + getNoise());
        }
    }
}
