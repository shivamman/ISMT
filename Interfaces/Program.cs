using System;

namespace Interfaces
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            IEmployeeService employeeService = new EmployeeService();
            employeeService.Add(new Employee { Id = 1, Name = "Barry Allen"});
        }
    }

    public interface IEmployeeService
    {
        void Add(Employee employee);
        void Delete(int Id);
    }

    public class EmployeeService : IEmployeeService
    {
        public void Add(Employee emp)
        {
            Console.WriteLine("The employee named {0} is added.", emp.Name);
        }

        public void Delete(int Id)
        {
            Console.WriteLine("The employee with Id {Id} is deleted", Id);
        }
    }

    public class AnotherService : IEmployeeService
    {
        public void Add(Employee employee)
        {
            throw new NotImplementedException();
        }

        public void Delete(int Id)
        {
            throw new NotImplementedException();
        }
    }

    public class Employee {
        public int Id { get; set; }
        public string Name { get; set; }
    }

}
