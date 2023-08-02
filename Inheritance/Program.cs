using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {

            var BaldEagle = new Bird();
            BaldEagle.LifeSpan = "20 years";
            BaldEagle.WingSpan = "3-5 feet";
            BaldEagle.Species = "bird";
            BaldEagle.Migrates = false;
            BaldEagle.Diet = "fish & rodents";
            BaldEagle.Color = "brown with a white head";
            BaldEagle.CanFly = true;
            BaldEagle.NumberOfEggs = "one to two eggs";

            Console.WriteLine($"A Bald Eagle is a type of {BaldEagle.Species}. They can live up to {BaldEagle.LifeSpan} and have a wingspan of {BaldEagle.WingSpan}");
            Console.WriteLine($"They are primarily {BaldEagle.Color} and their diet constists mainly of {BaldEagle.Diet}. They typically lay {BaldEagle.NumberOfEggs} each year");
            Console.WriteLine($"It is {BaldEagle.CanFly} that they can fly, but {BaldEagle.Migrates} that they migrate");

            Console.WriteLine("---------------------------------------------------------------");

            var Crocodile = new Reptile();
            Crocodile.LifeSpan = "50 years";
            Crocodile.Species = "reptile";
            Crocodile.Diet = "any type of meat";
            Crocodile.Color = "brown and green";
            Crocodile.ColdBlooded = true;
            Crocodile.Aquatic = true;
            Crocodile.Length = "up to 20 feet";
            Crocodile.Scales = "thick spikey scales";

            Console.WriteLine($"A crocodile is a type of {Crocodile.Species}. They can live to be {Crocodile.LifeSpan} old, and can grow {Crocodile.Length}!");
            Console.WriteLine($"Their diet constists of {Crocodile.Diet}, and they are primarily {Crocodile.Color} with {Crocodile.Scales}.");
            Console.WriteLine($"It is {Crocodile.ColdBlooded} that they are cold-blooded, and also {Crocodile.Aquatic} that they are aquatic reptiles.");




            // TODO Be sure to follow best practice when creating your classes

            // Create a class Animal
            // give this class 4 members that all Animals have in common


            // Create a class Bird
            // give this class 4 members that are specific to Bird
            // Set this class to inherit from your Animal Class

            // Create a class Reptile
            // give this class 4 members that are specific to Reptile
            // Set this class to inherit from your Animal Class




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
