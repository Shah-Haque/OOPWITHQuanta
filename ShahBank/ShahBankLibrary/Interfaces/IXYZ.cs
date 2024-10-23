using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShahBankLibrary.Interfaces
{
    public interface IXYZ
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public void HelloWorld();

        void Greeting();

    }
}
