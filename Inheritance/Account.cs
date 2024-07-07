using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Account : Person
    {
        //Constructor
        public Account() { }
        public double getAccountBalance()
        {
            return currentAccount;
        }
        public double setAccountBalance(double amount)
        {
            return currentAccount += amount;
        }
        public double withdrawFromAccount(double amountToWithdraw)
        {
            return currentAccount -= amountToWithdraw;
        }
    }
}
