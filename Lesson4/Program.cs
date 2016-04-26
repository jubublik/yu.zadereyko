using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4
{
    class Program
    {
        static void Main(string[] args)
        {
            Phone a = new Phone("999", "999999");
            Phone2 b = new Phone2("495", "726262");
            a.GetPhoneNumber();
            string result = b.GetPhoneNumber;

            Console.WriteLine(a.GetPhoneNumber());
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }  
}
