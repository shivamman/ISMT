using System;

namespace EncapsulationAndAbstraction
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
            NewBank newBank = new NewBank();
            newBank.Name = "NIC ASIA";
            newBank.Branch = "Baneswor";

            newBank.EnterUserDetails(newBank);

            newBank.AccountBalance = 2000;
            Console.WriteLine(newBank.AccountBalance);
        }
    }

    public class NewBank
    {
        private int _accountBalance = 1000;
        public string Name { get; set; }
        public string Branch { get; set; }

        public int AccountBalance { get {
                return _accountBalance;
            }
            set {
                this._accountBalance = value;
            } 
        }

        public void EnterUserDetails(NewBank newBank)
        {
            // User enter Details
            if (Validation(newBank))
            {
                if (ConnectToDataBase())
                {
                    InsertDetails(newBank);
                }
            }
        }

        private void InsertDetails(NewBank newBank)
        {
         
        }


        static bool Validation(NewBank newBank)
        {
            return true;
        }

        private bool ConnectToDataBase()
        {
            //Connection
            return true;
        }
    }
}
