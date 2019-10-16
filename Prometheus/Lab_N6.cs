using System;

namespace Lab_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat("grey", 12, 2);
            Dog dog = new Dog("black", 15, 3);

            Console.WriteLine(cat.ToString());
            Console.Write("And he said: ");
            Console.WriteLine(cat.MakeSound());

            Console.WriteLine(dog.ToString());
            Console.Write("And he said: ");
            Console.WriteLine(dog.MakeSound());

            Console.ReadLine();
        }
    }

    public abstract class Animal
    {
        public string Color { get; set; }
        public float Weight {get; set; }
        public Animal(string color, float weight)
        {
            this.Color = color;
            this.Weight = weight;
        }

        public abstract string MakeSound();
    }

    public abstract class AnimalWithTail : Animal
    {
        public float TailLength { get; set; }

        public AnimalWithTail(string color, float weight, float tailLength) : base(color, weight)
        {
            this.TailLength = tailLength;
        }

    }

    public class Cat : AnimalWithTail
    {
        public Cat(string color, float weight, float tailLength) : base(color, weight, tailLength)
        {
        }

        private string Purr ()
        {
            return "purrrrrrrr";
        }
        private string Meow()
        {
            return "Meow";
        }

        public override string MakeSound()
        {
            return Purr() + Meow();
        }

        public override string ToString()
        {
            return $"This is a Cat, Color = {Color}, Weight = {Weight}, TailLength = {TailLength}";
        }
    }

    public class Dog : AnimalWithTail
    {
        public Dog(string color, float weight, float tailLength) : base(color, weight, tailLength)
        {
        }

        public override string MakeSound()
        {
            return "Woof";
        }

        public override string ToString()
        {
            return $"This is a Dog, Color = {Color}, Weight = {Weight}, TailLength = {TailLength}";
        }
    }
}

