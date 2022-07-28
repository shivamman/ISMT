namespace Relationships
{
    public class Customer
    {
        private Order _order;   
        public Customer()
        {
            this._order = new Order();
        }
    }

}
