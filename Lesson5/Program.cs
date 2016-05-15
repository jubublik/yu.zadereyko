using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseClient client = new BaseClient();
            BaseClient client2 = new BaseClient();
            StandartClient standart = new StandartClient();
            StandartClient standart2 = new StandartClient();
            standart.AddAccount(new CheckingAccount(12, "2322000", 100));
            standart.AddAccount(new MetalAccount("Au", 12, 25, "4040000"));
            standart2.AddAccount(new CheckingAccount(12, "1331000", 500));
            Console.WriteLine($"Общая сумма: {client.TotalBalace}");
            standart.AccountList();
            standart2.AccountList();
            standart.CompareTo(standart);
            client.AccountList();

            BaseClient[] compare = new BaseClient[] { standart, standart2 };
            Array.Sort(compare);

            for (int i = 0; i < compare.Length; i++)
            {
                Console.WriteLine(compare[i].TotalBalace);
            }
  
        }
    }
}
