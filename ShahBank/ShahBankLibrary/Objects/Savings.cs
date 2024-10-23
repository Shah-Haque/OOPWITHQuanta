using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ShahBankLibrary.Objects
{
    public class Savings : Account
    {

        static Savings() 
        {
           InterestRate = 2.5;
        }
        public Savings(int AccountNum = 999, string CustomerName = "Not Yet Set", decimal Balance =10) 
        : base(CustomerName, AccountNum, Balance)
        {
           
        }

        public static double InterestRate { get; set; }


        public override void Withdraw(decimal amount)
        {
            if (amount <= this.Balance)
            {
                Balance -= amount;
            }
        }
    }
}
