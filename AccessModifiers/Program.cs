using InheritanceAndPolimorphism;
using System;

namespace AccessModifiers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Animal animal = new Animal();
            animal.Name = "Dog";
            Console.WriteLine(animal.GetScientificName());
            Employee employee = new Employee("Bruce", "Wayne");
            string fullName = employee.GetFullName();
            employee.PrintFullName();
            Console.WriteLine("From Program"+ fullName);
            PartTimeEmployee partTimeEmployee = new PartTimeEmployee("Peter", "Parker");
            partTimeEmployee.PrintSalary();
            Testing testing = new Testing();
            testing.Id = 1;
        }
    }

    public class Animal
    {
        public string Name { get; set; }
        private string ScientificName { get; set; }

        public string GetScientificName()
        {
            ScientificName = "Test";
            return ScientificName;
        }
    }

    public class Cat: Animal
    {

    }

    public class Tiger: Cat
    {
        public Tiger()
        {
            this.Name = "Begal Tiger";
        }
    }

}
