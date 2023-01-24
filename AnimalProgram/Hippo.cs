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
        public Hippo(string name, int age, float weight) 
        {
            setName(name);
            setAge(age);
            setWeight(weight);
            setNoise("erff");
        }

        public override void makeNoise()
        {
            Console.WriteLine(getName() + " " + getNoise() + "s!");
        }

        public override void ageUp()
        {
            setAge(getAge() + 1);
        }

        public override void printInfo()
        {
            Console.WriteLine("Name: " + getName());
            Console.WriteLine("Age: " + getAge());
            Console.WriteLine("Weight: " + getWeight());
            Console.WriteLine("Noise: " + getNoise());
        }
    }
}
