﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Сделать класс Клиент, который может содержать множество счетов(можно взять те, что в ДЗ). Сделать свойство, отображающее общую сумму денег на всех счетах.
//Добавить 2 разных счета.

namespace Lesson5
{
    class BaseClient : IComparable
    {
        protected List<SavingsAccount> Accounts { get; set; }
        protected int AccountsCount { get; set; }

        public BaseClient()
        {
            Accounts = new List<SavingsAccount>();
        }

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

        public void AccountList()
        {
            for (int i = 0; i < Accounts.Count; i++)
            {
                Console.WriteLine($"Номер счета и сумма - {Accounts[i].AccountNumber} : {Accounts[i].Balance}");
            }
        }

        public virtual void AddAccount(SavingsAccount account)
        {
            if (Accounts.Count < AccountsCount)
            {
                Accounts.Add(account);
            }
            else
            {
                throw new ArgumentOutOfRangeException("Превышен лимит счетов");
            }
        }

        public void CloseAccount(string accountNumber)
        {
            SavingsAccount account = null;

            for (int i = 0; i < Accounts.Count; i++)
            {
                if (Accounts[i].AccountNumber == accountNumber)
                {
                    account = Accounts[i];
                    break;
                }
            }

            if (account != null)
            {
                account.CloseAccount(); 
            }
            else
            {
                throw new ArithmeticException("Счёт не найден");
            }
        }

        public int CompareTo(object obj)
        {
            BaseClient client = (BaseClient)obj;
            if (TotalBalace > client.TotalBalace)
                return 1;
            if (TotalBalace < client.TotalBalace)
                return -1;

            return 0;
        }
    }
}
