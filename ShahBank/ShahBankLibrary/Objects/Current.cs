using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShahBankLibrary.Objects
{
    public class Current : Account
    { 
        public delegate void theHandler(Current sender);
        public event theHandler? OverdraftLimitExceeded;

            public Current(int CustomerNum = 999, string CustomerName = "Not Yet Set", decimal Balance = 10, decimal OverdraftLimit = 250) 
            : base(CustomerName,CustomerNum ,Balance)
            {
                this.OverdraftLimit = OverdraftLimit;

            }
        public decimal OverdraftLimit { get; set; }

       

        public override void Withdraw(decimal amount) 
        {
            if (amount <= GetBalance() + OverdraftLimit)
            {
                this.Balance -= amount;
            }
            else 
            {
                this.Balance -= amount + 10;
                this.OverdraftLimitExceeded?.Invoke(this);
            }
        }
    }
}
