using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5
{
    class Bank
    {
        private static void Transaction(SavingsAccount from, SavingsAccount to, decimal sum)
        {
            if (!from.IsActive)
            {
                Console.WriteLine("Счет списания не активен, операция невозможна");
            }

            else if (!to.IsActive)
            {
                Console.WriteLine("Счет получения не активен, операция невозможна");
            }

            else
            {
                from.DecreaseBalance(sum);
                to.IncreaseBalance(sum);
            }
        }
    }
}
