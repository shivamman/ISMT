namespace ClassTypesAndValueTypes
{
    //public static class ReferenceType 
    //{
    //    public static void Set(Student student)
    //    {
    //        student.Id = 1;
    //        student.Name = "Shivam";
    //    }
    //}

    //public static class ValueType
    //{
    //    public static void Set(string data)
    //    {
    //        data = "Batman";
    //    }

    //    public static void SetBool(bool data)
    //    {
    //        data = false;
    //    }
    //}

    sealed class Student
    {
        private Student()
        {
                
        }
        public int Id { get; set; }
        public string Name { get; set; }
    }

    
}
