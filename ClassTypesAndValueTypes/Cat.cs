namespace ClassTypesAndValueTypes
{
    //Nested Class

    public class Cat
    {
        public int Id { get; set; }
        public class Tiger:Cat
        {
            public string Species { get; set; }
            public Tiger(string species)
            {
                this.Species = species;
            }
        }
    }

   
}
