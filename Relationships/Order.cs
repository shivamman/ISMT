namespace Relationships
{
    public class Order
    {
        public Animal _animal;
        public Order()
        {
            _animal = new Animal();
        }
        public int Id { get; set; }
        public void OrderTheValue()
        {

        }
    }

}
