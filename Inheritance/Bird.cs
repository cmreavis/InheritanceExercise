using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    public class Bird : Animal
    {
        public string beakShape;
        public const bool hollowBones = true;
        public bool canFly;
        public string eggColor;

        public void GetBirdProperties()
        {
            Console.WriteLine($"All animals are eukaryotes? \n {isEukaryotic}. \n This animal uses its {mobilityType} to get around, has an average lifespan of {avgLifespan}, and is a {diet}.");
            Console.WriteLine();
            Console.WriteLine($"This bird features a {beakShape} beak, its ability to fly is {canFly}, eggs are {eggColor} in color, \n and as with all birds, do they have a hollow skeleton? {hollowBones}.");
        }


    }
}
