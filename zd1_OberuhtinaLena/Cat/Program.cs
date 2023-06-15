using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cat
{
    class Program
    {
        static void Main (string[] args)
        {
            Console.WriteLine("Введите имя кота:");
            string name = Console.ReadLine();
            Console.WriteLine("Введите вес кота в кг:");
            string ves = Console.ReadLine();
            Cat cat= new Cat(name,ves);
            if(cat.Chec())
            cat.Meow();
            Console.ReadLine();

        }
    }
}
