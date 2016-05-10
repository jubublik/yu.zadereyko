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
            client.AddAccount(new CheckingAccount(12,"2322000",100));
            client.AddAccount(new MetalAccount("Au", 12, 25,"4040000", 200));
            Console.WriteLine($"Общая сумма: {client.TotalBalace}");
            client.AccountList();
            client.CloseAccount("4040000");
            Console.ReadLine();
        }
    }
}
