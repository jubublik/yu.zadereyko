using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5
{
    class StandartClient : BaseClient
    {
        public override void AddAccount(SavingsAccount account)
        {
            if (Accounts.Count < 3)
            {
                base.AddAccount(account);
            }
            else
            {
                Console.WriteLine("Превышен лимит счетов");
            }
        }
    }
}
