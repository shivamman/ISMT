using InheritanceAndPolimorphism;
using System;

namespace ISMTSesason2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Sum(1500,1500);
            Sum("Bat", "man");
            Animal animal = new Animal();
            Dog dog = new Dog();
            dog.MakeSound();
            animal.MakeSound();
            Console.ReadLine();
            Testing testing = new Testing();
            testing.Id = 1;
            testing.Name = "Test";
        }

        private static void Sum(int a, int b)
        {
            Console.WriteLine(a + b);
        }

        //private static void Sum(int a, string b)
        //{
        //    Console.WriteLine(a + b);
        //}

        private static void Sum(string a, string b)
        {
            Console.WriteLine(a+b);
        }
    }

    public class Animal
    {
        public string AnimalName { get; set; }
        public string ScientificName { get; set; }

        public virtual void MakeSound()
        {
            Console.WriteLine("Animals can't talk like Humans");
        }
    }

    public class Dog: Animal {
        public override void MakeSound()
        {
            Console.WriteLine("Dogs Bark");
        }
    }
}
