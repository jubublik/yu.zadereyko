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
            Ltd company = new Ltd("2GIS", "1231232132z", 1000);
            Individual individual = new Individual("Иванов", "Иван", "Иванович", new DateTime(1901, 2, 2), 200);
            Console.WriteLine(company.ToString());
            Console.WriteLine(individual.ToString());
            SavingsAccount savings = new SavingsAccount(100);
            savings.IncreaseBalance(10);
            savings.DecreaseBalance(110);
            savings.CloseAccount();
            savings.DecreaseBalance(110);
            Console.WriteLine(savings);
            AccumulationAccount accum = new AccumulationAccount(100,24,100);
            accum.IncreaseBalance(10);
            accum.ApplyCapitalization();
            accum.CloseAccount();
            Console.WriteLine(accum);
            CheckingAccount check = new CheckingAccount(50,300);
            check.ApplyServiceCharge();
            Console.WriteLine(check);
            MetalAccount metal = new MetalAccount("Золото", 23, 100, 3000);
            metal.DecreaseBalance(1000);
            Console.WriteLine(metal);
            Console.ReadLine();
        }
    }
}
