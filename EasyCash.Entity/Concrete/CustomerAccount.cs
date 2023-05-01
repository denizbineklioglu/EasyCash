using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyCash.Entity.Concrete
{
    public class CustomerAccount
    {
        public int CustomerAccountID { get; set; }
        public string Number { get; set; }
        public string Currency { get; set; }
        public decimal Balance { get; set; }
        public string BankBranch { get; set; }        
    }
}
