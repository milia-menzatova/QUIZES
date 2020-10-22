using System;

namespace AnimalShelter
{
    class Program
    {
        static void Main(string[] args)
        {
            var dog = new Pet("dog", "Gumaro", "male", true, "Mixed Breed", 2.1);
            var cat = new Pet("cat", "Lily", "female", false, "Domestic Shorthair", 12);
        }
    }

    public class Pet
    {
        public string name { get; set; }
        public string petType { get; set; }
        public string gender { get; set; }
        public bool neutered { get; set; }
        public string breed { get; set; }
        public double age { get; set; }

        public Pet(string petType, string name, string gender, bool neutered, string breed, double age)
        {
            this.petType = petType;
            this.name = name;
            this.gender = gender;
            this.neutered = neutered;
            this.breed = breed;
            this.age = age;
        }
    }
}
