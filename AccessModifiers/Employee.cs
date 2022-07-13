using System;

namespace AccessModifiers
{
    public class Employee
    {
        public Employee(string FirstName, string LastName)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
        }

        private string FirstName { get; set; }
        private string LastName { get; set; }
        protected decimal Salary { get; set; }
        public string GetFullName()
        {
            return string.Format("{0} {1}", FirstName, LastName);
        }

        public void PrintFullName()
        {
            Console.WriteLine(string.Format("{0} {1}", FirstName, LastName));
        }
    }

}
