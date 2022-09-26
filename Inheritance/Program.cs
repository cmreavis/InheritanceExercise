using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes
            //***All created classes are in separate tabs***

            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */

            Bird hyacinthMacaw = new Bird()
            {
                beakShape = "curved",
                canFly = true,
                eggColor = "white",
                mobilityType = "wings",
                avgLifespan = 50,
                diet = "herbivore",
            };
            Console.WriteLine("The Hyacinth Macaw:");
            Console.WriteLine();
            hyacinthMacaw.GetBirdProperties();

            Console.WriteLine();
        /*Create an object of your Reptile class
         *  give values to your members using the object of your Reptile class
         *  
         * Creatively display the class member values 
         */

            Console.WriteLine("The Iguana:");
            Console.WriteLine();
            Reptile iguana = new Reptile()
            {
                eggs = true,
                numberOfLungs = 2,
                mobilityType = "legs",
                avgLifespan = 14,
                diet = "herbivore",
            };
            iguana.GetReptileProperties();

        }


     }

}

