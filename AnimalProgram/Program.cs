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
                }

                // Print info
                else if (choice == 2) 
                { 
                
                }

                // Listen to the noises
                else if (choice == 3) 
                {
                
                }

                // Age up animals
                else if (choice == 4)
                {

                }

                // Exit
                else
                {
                    Console.WriteLine("Exiting...")
                }
            }
        }
    }
}
