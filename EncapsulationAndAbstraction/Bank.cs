namespace EncapsulationAndAbstraction
{
    public class Bank
    {
        public string Name { get; set; }
        private int AccountBalance = 1000;

        //Setter Method
        public void SetBalance(int balance) {
            this.AccountBalance = balance;
        }

        //Getter Method
        public int GetBalance() {
            return this.AccountBalance;
        }
    }
}
