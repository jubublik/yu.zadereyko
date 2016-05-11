﻿using System;
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
            StandartClient standart = new StandartClient();
            standart.AddAccount(new CheckingAccount(12,"2322000",100));
            standart.AddAccount(new MetalAccount("Au", 12, 25,"4040000"));
            standart.AddAccount(new CheckingAccount(12, "1331000", 500));
            Console.WriteLine($"Общая сумма: {client.TotalBalace}");
            standart.AccountList();
            client.AccountList();
            client.CloseAccount("4040000");
            Console.ReadLine();
        }
    }
}
