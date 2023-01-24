using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalProgram
{
    internal class World
    {
        static void Main(string[] args)
        {
            int choice = 100;
            List<Animal> animals = new List<Animal>();

            // Menu
            while (choice != 0) 
            {
                Console.WriteLine("Menu:");
                Console.WriteLine("1: Add an animal");
                Console.WriteLine("2: Print info of all animals");
                Console.WriteLine("3: Listen to the noise of your animals");
                Console.WriteLine("4: Age up all of your animals by one year");
                Console.WriteLine("0: Exit the program\n");

                Console.Write("What would you like to do: ");
                choice = Int32.Parse(Console.ReadLine());
                Console.WriteLine();

                // User error check
                if(choice <= 0 && choice >= 4)
                {
                    Console.WriteLine(choice + " is not a choice. Please try again.");
                    Console.Write("What would you like to do: ");
                    choice = Int32.Parse(Console.ReadLine());
                    Console.WriteLine();
                }

                // Add an Animal
                if (choice == 1)
                {
                    int animalChoice = 0;
                    Console.WriteLine("What type of animal would you like to add?");
                    Console.WriteLine("1: Cat\n2: Cassowary\n3: Hippo\n");
                    animalChoice = Int32.Parse(Console.ReadLine());
                    Console.WriteLine();

                    // User error check
                    if(animalChoice < 1 && animalChoice > 3)
                    {
                        Console.WriteLine(animalChoice + " is not an option. Please try again.");
                        Console.WriteLine("What type of animal would you like to add?");
                        Console.WriteLine("1: Cat\n2: Cassowary\n3: Hippo\n");
                        animalChoice = Int32.Parse(Console.ReadLine());
                        Console.WriteLine();
                    }

                    // animal selections
                    // Cat
                    if (animalChoice == 1)
                    {
                        Console.WriteLine("What is the name of your Cat?");
                        string animalName = Console.ReadLine();
                        Console.WriteLine("What is the age of " + animalName + "?");
                        int animalAge = Int32.Parse(Console.ReadLine());
                        Console.WriteLine("What is " + animalName + "'s weight in pounds? (e.g. 13.52)");
                        float animalWeight = float.Parse(Console.ReadLine());
                        Console.WriteLine();

                        Cat c = new Cat(animalName, animalAge, animalWeight);
                        animals.Add(c);

                        Console.WriteLine("Added your Cat to the World!\n");
                    }

                    // Cassowary
                    else if (animalChoice == 2) 
                    {
                        Console.WriteLine("What is the name of your Cassowary?");
                        string animalName = Console.ReadLine();
                        Console.WriteLine("What is the age of " + animalName + "?");
                        int animalAge = Int32.Parse(Console.ReadLine());
                        Console.WriteLine("What is " + animalName + "'s weight in pounds? (e.g. 133.24)");
                        float animalWeight = float.Parse(Console.ReadLine());
                        Console.WriteLine();

                        Cassowary cass = new Cassowary(animalName, animalAge, animalWeight);
                        animals.Add(cass);

                        Console.WriteLine("Added your Cassowary to the World!\n");
                    }

                    // Hippo
                    else
                    {
                        Console.WriteLine("What is the name of your Hippo?");
                        string animalName = Console.ReadLine();
                        Console.WriteLine("What is the age of " + animalName + "?");
                        int animalAge = Int32.Parse(Console.ReadLine());
                        Console.WriteLine("What is " + animalName + "'s weight in pounds? (e.g. 557.21)");
                        float animalWeight = float.Parse(Console.ReadLine());
                        Console.WriteLine();

                        Hippo hippo = new Hippo(animalName, animalAge, animalWeight);
                        animals.Add(hippo);

                        Console.WriteLine("Added your Hippo to the World!\n");
                    }
                }

                // Print info
                else if (choice == 2) 
                {
                    int i = 1;
                    foreach (Animal ani in animals) 
                    {
                        Console.WriteLine("Animal " + i + ":");
                        ani.printInfo();
                        Console.WriteLine();
                        i++;
                    }

                    if (animals.Count == 0)
                    {
                        Console.WriteLine("No animals in the World!\n");
                    }
                        
                }

                // Listen to the noises
                else if (choice == 3) 
                {
                    foreach (Animal ani in animals)
                    {
                        ani.makeNoise();
                    }

                    if (animals.Count == 0)
                    {
                        Console.WriteLine("No animals in the World!\n");
                    }
                }

                // Age up animals
                else if (choice == 4)
                {
                    Console.WriteLine("Aging each animal up by one year...\n");
                    foreach (Animal ani in animals)
                    {
                        ani.ageUp();
                    }

                    if (animals.Count == 0)
                    {
                        Console.WriteLine("No animals in the World!\n");
                    }
                }

                // Exit
                else
                {
                    Console.WriteLine("Exiting...");
                }
            }
        }
    }
}
