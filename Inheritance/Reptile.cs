using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    public class Reptile : Animal
    {
        public const bool coldBlood = true;
        public bool eggs;
        public int numberOfLungs;
        public const bool scales = true;

        public void GetReptileProperties()
        {
            Console.WriteLine($"All animals are eukaryotes? \n {isEukaryotic}. \n This animal uses its {mobilityType} to get around, has an average lifespan of {avgLifespan}, and is a {diet}.");
            Console.WriteLine();
            Console.WriteLine($"As with all reptiles, is this animal cold blooded? \n {coldBlood}. \n Does it have scales? \n {scales}. \n This reptile lays eggs? \n {eggs}. \n This reptile has {numberOfLungs} lungs.");
        }
    }
}
