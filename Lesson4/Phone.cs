using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4
{
    //Создать класс “Телефон”, который содержит следующие данные: код города, номер телефона, которые не могут быть изменены. 
    //Добавить метод, который возвращает строку вида “(999) 999999” или “999999”, если код города отсутствует.

    class Phone
    {
        readonly string Code;
        readonly string Number;

        public Phone(string code, string number)
        {
            Code = code;
            Number = number;
        }
        public string GetPhone()
        {
            string result;

            if (Code != "")
            {
                result = String.Format("({0}) {1}", Code, Number);
            }
            else
            {
                result = Number;
            }
            return result;
        }
    }



}
