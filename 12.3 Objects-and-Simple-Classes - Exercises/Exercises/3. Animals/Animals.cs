using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Animals
{
    class Dog
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int NumberOfLegs { get; set; }
        public void ProduceSound()
        {
            Console.WriteLine("I'm a Distinguishedog, and I will now produce a distinguished sound! Bau Bau.");
        }
    }
    class Cat
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int IntelligenceQuotient { get; set; }
        public void ProduceSound()
        {
            Console.WriteLine("I'm an Aristocat, and I will now produce an aristocratic sound! Myau Myau.");
        }
    }
    class Snake
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int CrueltyCoefficient { get; set; }
        public void ProduceSound()
        {
            Console.WriteLine("I'm a Sophistisnake, and I will now produce a sophisticated sound! Honey, I'm home.");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var Dogs = new Dictionary<string, Dog>();
            var Cats = new Dictionary<string, Cat>();
            var Snakes = new Dictionary<string, Snake>();

            var inputLine = Console.ReadLine();

            while (inputLine != "I'm your Huckleberry")
            {
                var inputParams = inputLine.Split(' ');

                if (inputParams.Length > 2)
                {
                    var type = inputParams[0];
                    var name = inputParams[1];
                    var age = int.Parse(inputParams[2]);
                    var parameter = int.Parse(inputParams[3]);

                    switch (type)
                    {
                        case "Dog":
                            Dog newDog = new Dog();

                            newDog.Name = name;
                            newDog.Age = age;
                            newDog.NumberOfLegs = parameter;

                            Dogs.Add(newDog.Name, newDog);
                            break;

                        case "Cat":
                            Cat newCat = new Cat();

                            newCat.Name = name;
                            newCat.Age = age;
                            newCat.IntelligenceQuotient = parameter;

                            Cats.Add(newCat.Name, newCat);
                            break;

                        case "Snake":
                            Snake newSnake = new Snake();

                            newSnake.Name = name;
                            newSnake.Age = age;
                            newSnake.CrueltyCoefficient = parameter;

                            Snakes.Add(newSnake.Name, newSnake);
                            break;
                    }
                }
                else
                {
                    var animalName = inputParams[1];
                    if (Dogs.ContainsKey(animalName))
                    {
                        Dogs[animalName].ProduceSound();
                    }
                    else if (Cats.ContainsKey(animalName))
                    {
                        Cats[animalName].ProduceSound();
                    }
                    else if (Snakes.ContainsKey(animalName))
                    {
                        Snakes[animalName].ProduceSound();
                    }
                }
                inputLine = Console.ReadLine();
            }
            foreach (var dog in Dogs.Values)
            {
                Console.WriteLine("Dog: {0}, Age: {1}, Number Of Legs: {2}", dog.Name, dog.Age, dog.NumberOfLegs);
            }

            foreach (var cat in Cats.Values)
            {
                Console.WriteLine("Cat: {0}, Age: {1}, IQ: {2}", cat.Name, cat.Age, cat.IntelligenceQuotient);
            }

            foreach (var snake in Snakes.Values)
            {
                Console.WriteLine("Snake: {0}, Age: {1}, Cruelty: {2}", snake.Name, snake.Age, snake.CrueltyCoefficient);
            }
        }
    }
}