using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Реализовать классы для описания клиентов двух типов: ИП и ООО. Каждый тип клиента имеет идентификатор, основной телефон, сумма заказа. 
//У ИП указывается ФИО, дата рождения. У ООО указывается название, банковский счет. Реализовать метод, который возвращает отформатированное название и сумму заказа.
namespace Lesson5
{
    class Individual : Client
    {
        public DateTime BirthDate { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }

        private string FullName
        {
            get
            {
                return $"{LastName} {FirstName} {MiddleName}";
            }
        }

        public override string ToString()
        {
            return $"{FullName} {Price}";
        }

        public Individual(string firstName, string middleName, string lastName, DateTime birthDate, decimal price) :base(price)
        {
            FirstName = firstName;
            MiddleName = middleName;
            LastName = lastName;
            BirthDate = birthDate;
        }
    }
}
