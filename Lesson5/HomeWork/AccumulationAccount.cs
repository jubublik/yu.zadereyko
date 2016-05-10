using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5
{
    class AccumulationAccount : SavingsAccount
    {
        public decimal InitialFee { get; set; }
        public decimal Rate { get; set; }

        public override bool DecreaseBalance(decimal amount)
        {
            if (amount >= InitialFee)
            {
                return base.DecreaseBalance(amount);
            }
            else
            {
                Console.WriteLine("Сумма списания не может быть меньше первоначального взноса");
                return false;
            }
        }

        public void ApplyCapitalization()
        {
            if (IsActive)
            {
                IncreaseBalance(Balance * ((Rate / 12) / 100));
            }
            else
            {
                NotActiveAccountMessage();
            }
        }

        public AccumulationAccount(decimal initialFee, decimal rate, string accountNumber, decimal balance) : base(accountNumber, balance)
        {
            InitialFee = initialFee;
            Rate = rate;
        }

    }
}
