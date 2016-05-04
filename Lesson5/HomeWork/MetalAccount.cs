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
        public decimal MetalWeight { get; set; }
        public decimal MetalPrice { get; set; }

        public override void IncreaseBalance(decimal amount)
        {
            base.IncreaseBalance(amount);
            MetalWeight = MetalWeight + amount / MetalPrice;
        }

        public override void DecreaseBalance(decimal amount)
        {
            base.DecreaseBalance(amount);
            MetalWeight = MetalWeight - amount / MetalPrice;
        }

        public MetalAccount(string metalType, decimal metalWeight, decimal metalPrice, decimal balance):base(balance)
        {
            MetalPrice = metalPrice;
            MetalType = metalType;
            MetalWeight = metalWeight;
        }
    }
}
