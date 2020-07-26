using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Budget
{
    class Accounts : DebitCredit
    {
        public int category { get; set; }
        public int day { get; set; }
        public string month { get; set; }
        public int year { get; set; }
    }
}
