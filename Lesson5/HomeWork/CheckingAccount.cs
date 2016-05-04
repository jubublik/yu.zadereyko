using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5
{
    class CheckingAccount : SavingsAccount
    {
        public decimal ServiceCharge { get; set; }

        public void ApplyServiceCharge()
        {
            DecreaseBalance(ServiceCharge);
        }

        public CheckingAccount(decimal serviceCharge, decimal balance):base(balance)
        {
            ServiceCharge = serviceCharge;
        }
    }
}
