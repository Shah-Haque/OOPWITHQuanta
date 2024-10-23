namespace ShahBankLibrary.Objects
{
    public abstract class Account
    {
        public Account(string CustomerName = "Not Yet Set", int AccountNum = 100, decimal Balance = 10)
        {
            this.AccountNum = AccountNum;
            this.CustomerName = CustomerName;
            this.Balance = Balance;
            NumberOfAccounts++;
        }
        public int AccountNum { get; set; }

        public string CustomerName { get; set; }

        protected decimal Balance { get; set; }

        public abstract void Withdraw(decimal amount);
        #region oldcode
        //{
        //    if (amount <= this.Balance)
        //    {
        //        Balance -= amount;
        //    }
        //}
        #endregion

        #region old property for NumberOfAccounts
        //private static int NumberOfAccounts = 0;

        //public int numberofAccounts
        //{
        //    get { return NumberOfAccounts; }
        //    set { NumberOfAccounts = value; }
        //}
        #endregion

        public static int NumberOfAccounts { get; set; }

        public void Deposit(decimal amount)
        {
            Balance += amount;
        }

        public decimal GetBalance()
        {
            return Balance;
        }
    }
}