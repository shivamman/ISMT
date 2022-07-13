using System;

namespace ConstructorsAndAbstractClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Constructor
            //Console.WriteLine("Hello World!");
            //Employee employee = new Employee(20000);
            //Employee employee2 = new Employee();
            //Employee employee3 = new Employee("Bruce", "Wayne", 300000);
            //Console.WriteLine(employee.Salary);
            //Console.WriteLine(string.Format("{0} {1} {2}", employee3.FirstName, employee3.LastName, employee3.Salary));
            //Console.WriteLine(employee);
            #endregion
            RE re = new RE();
            re.GetNameWithEngineNumber();
            re.MakeSound();

            Honda honda = new Honda();
            honda.MakeSound();

            Yatru yatru = new Yatru();
            yatru.MakeSound();
        }
    }

    public class Employee {
        private int _salary;
        public Employee(int salary)
        {
            this._salary = salary;
        }

        public Employee()
        {

        }

        public Employee(string firstName, string lastName, int salary)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this._salary = salary;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Salary { get { return _salary; } set { this._salary = value; } }

    }

    public abstract class Bike
    {
        public string Name { get; set; }
        public string EngineNumber { get; set; }

        public void GetNameWithEngineNumber() {
            Console.WriteLine(string.Format("{0} {1}", Name, EngineNumber));
        }

        public abstract void MakeSound();
    }

    public class RE : Bike
    {
        public override void MakeSound()
        {
            Console.WriteLine("Dhuk Dhuk");
        }
    }

    public class Honda : Bike
    {
        public override void MakeSound()
        {
            Console.WriteLine("Hooondaaaa");
        }
    }

    public class Yatru: Bike
    {
        public override void MakeSound()
        {
            Console.WriteLine("No Sound");
        }
    }

}
