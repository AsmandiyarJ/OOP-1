using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class People
    {
        public int age;
        public string surname = string.Empty;
        public string name = string.Empty;


        public void Setage(int age)
        {
            while (true)
            {
                if (age < 0 || age == 0)
                {
                    Console.WriteLine("Введите нормально возраст");
                    age = int.Parse(Console.ReadLine());
                    this.age = age;

                }
                else
                {
                    this.age = age;
                    break;
                }
            }
        }

        public void SetSurname(string surname)
        {
            while (true)
            {
                if (surname == "")
                {
                    Console.WriteLine("Введите Фамилию");
                    surname = Console.ReadLine();
                    this.surname = surname;
                }
                else
                {
                    this.surname = surname;
                    break;
                }
            }
        }

        public void Setname(string name)
        {
            while (true)
            {
                if (name == "")
                {
                    Console.WriteLine("Введите имя");
                    name = Console.ReadLine();
                    this.name = name;
                }
                else
                {
                    this.name = name;
                    break;
                }
            }
        }

        public void Print(int age,string surname,string name)
        {
            Console.WriteLine("Ваш Возраст :" + age);
            Console.WriteLine("Ваш Фамилия :" + surname);
            Console.WriteLine("Ваш Имя :" + name);
        }

    }
}
