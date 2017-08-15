using System;

namespace model_three_things
{
    class Program
    {
        public class Pet
        {
            //properties
            public string Name { get; set; }
            public string Species { get; set; }
            public string Breed { get; set; }
            public int Age { get; set; }

            //constructor
            public Pet(string name, string species, string breed, int age)
            {
                Name = name;
                Species = species;
                Breed = breed;
                Age = age;
            }

            //method
            public override string ToString()
            {
                return $"{Name}, a {Species} {Breed} who is {Age}.";

            }

        }
        class RPGS
        {
            //properties
            public string Name { get; set; }
            public string FavoriteCharacter { get; set; }
            public int PlayedFor { get; set; }
            public bool StillPlaying { get; set; }

            //constructor

            public RPGS(string name, string favoriteCharacter, int playedFor, bool stillPlaying)
            {
                Name = name;
                FavoriteCharacter = favoriteCharacter;
                PlayedFor = playedFor;
                StillPlaying = stillPlaying;
            }

            //method
            public override string ToString()
            {
                return $"{Name}, my favorite character was {FavoriteCharacter}, I played for {PlayedFor} years, am I still playing? {StillPlaying}.";
            }
        }

        class Car
        {
            //properties
            public string Make { get; set; }
            public string Model { get; set; }
            public int YearMade { get; set; }

            //constructor
            public Car(string make, string model, int yearMade)
            {
                Make = make;
                Model = model;
                YearMade = yearMade;
            }

            //method
            public override string ToString()
            {
                return $"I own a {YearMade} {Make} {Model}.";
            }


        }

        static void Main(string[] args)
        {
            //pets
            var hank = new Pet("Hank", "Hound mix", "Dog", 10);

            //RPGS
            var warCraft = new RPGS("World of Warcraft", "Warlock Class", 8, false);

            //car
            var myCar = new Car("Toyota", "Corolla", 2009);

            Console.WriteLine($"My pet is {hank}. My favorite RPG is {warCraft} {myCar}");

        }
    }
}
