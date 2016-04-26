using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Преобразовать класс “Телефон” на работу со свойствами

namespace Lesson4
{
    internal class Phone2
    {
        private readonly string Code;
        private readonly string Number;

        public Phone2(string code, string number)
        {
            Code = code;
            Number = number;
        }

        public string GetPhoneNumber
        {
            get
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
}
