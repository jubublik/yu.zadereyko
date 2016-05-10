using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5
{
    class CheckingAccount : SavingsAccount
    {
        public decimal ServiceCharge { get; private set; }

        public void ApplyServiceCharge()
        {
            DecreaseBalance(ServiceCharge);
        }

        public CheckingAccount(decimal serviceCharge, string accountNumber, decimal balance):base(accountNumber, balance)
        {
            ServiceCharge = serviceCharge;
        }
    }
}
