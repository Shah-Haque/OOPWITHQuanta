using ShahBankLibrary.Interfaces;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShahBankLibrary.Objects
{
    public class Offshore : Account, IXYZ
    {
        public int ID { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Greeting()
        {
            throw new NotImplementedException();
        }

        public void HelloWorld()
        {
            throw new NotImplementedException();
        }

        public override void Withdraw(decimal amount)
        {
            Console.WriteLine("TEST");
        }
    }
}
