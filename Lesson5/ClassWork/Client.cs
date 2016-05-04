using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Реализовать классы для описания клиентов двух типов: ИП и ООО. Каждый тип клиента имеет идентификатор, основной телефон, сумма заказа. 
//У ИП указывается ФИО, дата рождения. У ООО указывается название, банковский счет. Реализовать метод, который возвращает отформатированное название и сумму заказа.

namespace Lesson5
{
    class Client
    {
        public int Id { get; set; }
        public string Phone { get; set; }
        protected decimal Price { get; set; }

        public Client(decimal price)
        {
            Price = price;
        }
    }
}
