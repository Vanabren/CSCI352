// Name: Vance Brender-A-Brandis
// Date: 1/24/23
// Description: Abstract animal class

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalProgram
{
    public abstract class Animal
    {
        private string name;
        private int age;
        private string noise;
        private float weight;

        // Name var accessor
        public string getName()
        {
            return name;
        }

        // Age var accessor
        public int getAge() 
        {
            return age; 
        }

        // Noise var accessor
        public string getNoise() 
        { 
            return noise; 
        }

        // Weight var accessor
        public float getWeight() 
        { 
            return weight; 
        }

        // Name var accessor
        public void setName(string name)
        {
            this.name = name;
        }

        // Age var setter
        public void setAge(int age)
        {
            this.age = age;
        }

        // Noise var setter
        public void setNoise(string noise)
        {
            this.noise = noise;
        }

        // Weight var setter
        public void setWeight(float weight)
        {
            this.weight = weight;
        }

        // Abstract function for printing info of animal
        public abstract void printInfo();

        // Abstract function for printing animal noise
        public abstract void makeNoise();

        // Ages up animal by one year
        public abstract void ageUp();
    }
}
