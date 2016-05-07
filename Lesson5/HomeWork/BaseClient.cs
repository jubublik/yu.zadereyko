using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Сделать класс Клиент, который может содержать множество счетов(можно взять те, что в ДЗ). Сделать свойство, отображающее общую сумму денег на всех счетах.
//Добавить 2 разных счета.

namespace Lesson5
{
    class BaseClient
    {
        public List<SavingsAccount> Accounts { get; set; }

        public decimal TotalBalace
        {
            get
            {
                decimal sum = 0;

                for (int i = 0; i < Accounts.Count; i++)
                {
                    sum += Accounts[i].Balance;
                }

                return sum;
            }
        }
    }
}
