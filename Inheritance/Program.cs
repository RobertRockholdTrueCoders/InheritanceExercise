using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes

            // Create a class Animal
            // give this class 4 members that all Animals have in common


            // Create a class Bird
            // give this class 4 members that are specific to Bird
            // Set this class to inherit from your Animal Class

            // Create a class Reptile
            // give this class 4 members that are specific to Reptile
            // Set this class to inherit from your Animal Class
            var eagle = new Bird();
            eagle.CanFly = true;
            eagle.BeakSize = 2.2;
            eagle.HairColor = "Brown";
            eagle.DoesMigrate = true;

            var crocodile = new Reptile();
            crocodile.CanRegenerate = true;
            crocodile.Habitat = "Swamp";
            crocodile.HasScales = true;
            crocodile.LivesLong = true;

            var myAnimals = new Animal[] { eagle, crocodile };
            foreach (var animal in myAnimals)
            {
                Console.WriteLine($"The Animal is alive: {animal.IsAlive}");
                Console.WriteLine($"The Animal has hair: {animal.HasHair}");
                Console.WriteLine($"This Animal has {animal.LegCount} legs");
                Console.WriteLine($"The Animal moves by {animal.LandAirWater}");
            }


            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *
             * Creatively display the class member values
             */

            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *
             * Creatively display the class member values
             */
        }
    }
}
