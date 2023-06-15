using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cat
{
    class Cat
    {
        private string name; // скрытое поле
        private string ves;
        public bool chec = true;
        public bool Chec()
        {
            return chec;
        }
        public string Ves
        {
            get
            {
                return ves;
            }
            set
            {
                bool OnlyDigit = true;
                // ключ. слово value - это то, что хотят свойству присвоить
                foreach (var ch in value.ToString())
                {
                    if (ch == '.' || ch == ',')
                        continue;
                    if (!char.IsDigit(ch))
                    {
                        OnlyDigit = false;
                    }
                }

                if (OnlyDigit&& Convert.ToDouble(value)>0)
                {
                    ves= value;
                } else
                {
                    chec = false;
                    Console.WriteLine($"{value} - неправильный вес!!!");
                }
            }
        }
        public string Name // свойство, реализуем инкапсуляцию!
        {
            // получение значения - просто возврат name
            get
            {
                return name;
            }
            // установка значения - используем проверку
            set
            {
                bool OnlyLetters = true;
                // ключ. слово value - это то, что хотят свойству присвоить
                foreach (var ch in value)
                {
                    if (!char.IsLetter(ch))
                    {
                        OnlyLetters = false;
                    }
                }

                if (OnlyLetters)
                {
                    chec = true;
                    name = value;
                } else
                {
                    chec = false;
                    Console.WriteLine($"{value} - неправильное имя!!!");
                }
            }


        }
        public Cat (string CatName, string ves)
        {
            Name = CatName;
            Ves = ves;
        }
        public void Meow ()
        {
            Console.WriteLine($" кот {name} говорит: МЯЯЯЯУ!!!!. И весит {ves} кг");
        }
    }


}


