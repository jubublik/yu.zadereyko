using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4
{
    //Создать класс “Телефон”, который содержит следующие данные: код города, номер телефона, которые не могут быть изменены. 
    //Добавить метод, который возвращает строку вида “(999) 999999” или “999999”, если код города отсутствует.

    internal class Phone
    {
        private readonly string Code;
        private readonly string Number;

        public Phone(string code, string number)
        {
            Code = code;
            Number = number;
        }

        public string GetPhoneNumber()
        {
            string result;

            if (Code != "")
            {
                result = $"({Code}) {Number}";
            }
            else
            {
                result = Number;
            }

            return result;
        }
    }
}
