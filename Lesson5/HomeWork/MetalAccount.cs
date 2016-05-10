using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5
{
    class MetalAccount : SavingsAccount
    {
        public string MetalType { get; set; }
        public decimal MetalWeight { get; private set;}
        public decimal MetalPrice { get; set; }

        public override bool IncreaseBalance(decimal amount)
        {
            if (base.IncreaseBalance(amount))
            {
                MetalWeight = MetalWeight + amount / MetalPrice;
                return true;
            }
            else
            {
                return false;
            }
        }

        public override bool DecreaseBalance(decimal amount)
        {
            if (base.DecreaseBalance(amount))
            {
                MetalWeight = MetalWeight - amount / MetalPrice;
                return true;
            }
            else
            {
                return false;
            }
        }

        public MetalAccount(string metalType, decimal metalWeight, decimal metalPrice, string accountNumber, decimal balance) : base(accountNumber, balance)
        {
            MetalPrice = metalPrice;
            MetalType = metalType;
            MetalWeight = metalWeight;
        }
    }
}
