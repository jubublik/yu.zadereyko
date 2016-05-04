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

        public override void IncreaseBalance(decimal amount)
        {
            if (amount >= InitialFee)
            {
                base.IncreaseBalance(amount);
            }
            else
            {
                Console.WriteLine("Сумма пополнения не может быть меньше первоначального взноса");
            }
        }

        public override void DecreaseBalance(decimal amount)
        {
            if (amount >= InitialFee)
            {
                base.DecreaseBalance(amount);
            }
            else
            {
                Console.WriteLine("Сумма списания не может быть меньше первоначального взноса");
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

        public AccumulationAccount(decimal initialFee,decimal rate, decimal balance) : base(balance)
        {
            InitialFee = initialFee;
            Rate = rate;
        }

    }
}
