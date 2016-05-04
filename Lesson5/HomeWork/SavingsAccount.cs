using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Реализовать классы для управления банковскими счетами.Каждый счет должен иметь номер, владельца, текущую сумму на счету не меньше нуля.Типы счетов: 
//сберегательный - возможность пополнения и изъятия денег со счета
//накопительный - возможность пополнения и изъятия денег со счета, но не меньше первоначального взноса, наличие процентной ставки, капитализация процентов за месяц
//расчетный - возможность пополнения и изъятия денег со счета, наличие платы за обслуживание, списание суммы за обслуживание со счета
//обезличенный металлический счет - тип металла, количество грамм, стоимость за грамм (текущий курс), возможность пополнять и обналичивать счет по текущему курсу
//Реализовать метод закрытия счета.С закрытым счетом нельзя проводить никакие операции. Счет не может быть закрыт, если он имеет положительный баланс.

namespace Lesson5
{
    class SavingsAccount
    {
        public string AccountNumber { get; set; }
        public string UserName { get; set; }
        protected decimal Balance { get; set; }

        public bool IsActive { get; set; }

        public virtual void IncreaseBalance(decimal amount)
        {
            if (IsActive)
            {
                Balance = Balance + amount;
            }
            else
            {
                NotActiveAccountMessage();
            }
        }

        protected virtual void NotActiveAccountMessage()
        {
            Console.WriteLine("Счет закрыт, операции не доступны.");
        }

        public virtual void DecreaseBalance(decimal amount)
        {
            if (IsActive)
            {
                if (amount <= Balance)
                {
                    Balance = Balance - amount;
                }

                else
                {
                    Console.WriteLine("Сумма списания не может превышать баланс");
                }
            }
            else
            {
                NotActiveAccountMessage();
            }
        }

        public void CloseAccount()
        {
            if (IsActive)
            {
                if (Balance == 0)
                {
                    IsActive = false;
                }
                else
                {
                    Console.WriteLine("Счет не может быть закрыт, так как имеет положительный баланс");
                }
            }
            else
            {
                NotActiveAccountMessage();
            }
        }

        public SavingsAccount()
        {
            Balance = 0;
            IsActive = true;
        }


        public SavingsAccount(decimal balance)
        {
            Balance = balance;
            IsActive = true;
        }

        public override string ToString()
        {
            return $"{Balance}";
        }
    }
}
