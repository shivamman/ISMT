namespace ClassTypesAndValueTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            #region StaticExamples
            //Console.WriteLine("Hello World!");   
            //Cat cat = new Cat();
            //Cat.Tiger tiger = new Cat.Tiger("Siberian Tiger");
            //Console.WriteLine(tiger.Species);

            //Employee emp = new Employee()
            //{
            //    Id = 1,
            //    Name = "Sadan M",
            //    EmployeeType = EmployeeDetails.PartTime
            //};

            //Employee emp2 = new Employee
            //{
            //    Id = 2,
            //    Name = "Krishna",
            //    EmployeeType = EmployeeDetails.FullTime
            //};
            //Console.WriteLine(emp.EmployeeType);
            //Console.WriteLine(emp2.EmployeeType);
            #endregion
            PEmployee pemp = new PEmployee();

            Employees emp = new Employees();
            emp.Id = 10;
            emp.Name = "Jarvis";

            int number = 1000;

            ReferenceTypeExample.SetValue(emp);
            ValueTypeExample.Setup(number);

            System.Console.WriteLine("Id {0} Name {1}", emp.Id, emp.Name);
            System.Console.WriteLine(number);
        }
    }
    public class Employees {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Salary { get; set; }
        public class FullTImeEmployee: Employees {
            public int WorkingMonth { get; set; }
        }
        public class PartTimeEmployee: Employees {
            public int WorkingHour { get; set; }
        }
    }

    public static class ReferenceTypeExample {

        public static void SetValue(Employees emp) {
            emp.Id = 1;
            emp.Name = "Alfred";
        }
    }

    public static class ValueTypeExample
    {
        public static void Setup(int number) {
            number = 1;
        }
    }

    public partial interface IStudentService
    {
        void Add();
    }
    public partial interface IStudentService
    {
        void Udpate();
    }

    public class StudentService : IStudentService
    {
        public void Add()
        {
            throw new System.NotImplementedException();
        }

        public void Udpate()
        {
            throw new System.NotImplementedException();
        }
    }

    public partial class PartialMethod
    {
        partial void Add();
    }

    public partial class PartialMethod
    {
        partial void Add()
        {
            
        }
    }
}
