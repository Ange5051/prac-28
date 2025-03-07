﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Person
    {
        string name;
        string surname;
        int age;
        public string Name
        { 
            get 
            { 
                return name; 
            }
            set 
            { 
                name = value; 
            } 
        }
        public string Surname
        {
            get
            {
                return surname;
            }
            set
            {
                surname  = value;
            }
        }
        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                age = value;
            }
        }
        public Person()
        {
         
        }
        public Person(string name, string surname, int age)
        {
            this.Name = name;
            this.Surname = surname;
            this.Age = age;
        }
        public void Output()
        {
            Console.Write($"Имя:{Name}\n Фамилия:{Surname}\n Возраст:{Age}");
        }
    }
}
