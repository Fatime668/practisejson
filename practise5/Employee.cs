using System;
using System.Collections.Generic;
using System.Text;

namespace practise5
{
    class Employee
    {
        private static int _id;
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public Employee(string name,string surname,int age)
        {
            _id++;
            Id = _id;
            Name = name;
            Surname = surname;
            Age = age;

        }
    }
}
