using System;
using System.Collections.Generic;
using System.Text;

namespace PracticalWork5.Folder
{
    class ClassEmployee
    {
        private string fio;
        private string post;
        private string email;
        private string phone;
        private double salary;
        public int age;

        public ClassEmployee(string fio, string post, string email, string phone, double salary, int age)
        {
            this.fio = fio;
            this.post = post;
            this.email = email;
            this.phone = phone;
            this.salary = salary;
            this.age = age;
        }

        private string Info()
        {
            return string.Format($"ФИО: {this.fio}\nДолжность: {this.post}\nEmail: {this.email}" +
                $"\nНомер телефона: {this.phone}\nЗарплата: {this.salary}\nВозраст: {this.age}");
        }

        public void Print()
        {
            Console.WriteLine(Info());
        }


    }
}
