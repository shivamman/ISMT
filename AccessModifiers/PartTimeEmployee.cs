using System;

namespace AccessModifiers
{
    public class PartTimeEmployee : Employee
    {
        public PartTimeEmployee(string FirstName, string LastName) 
            : base(FirstName, LastName)
        {
        }

        public void PrintSalary()
        {
            this.Salary = 1000;
            Console.WriteLine(this.Salary);
        }

    }

}
