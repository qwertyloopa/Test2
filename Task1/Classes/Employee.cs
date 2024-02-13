﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.Classes
{
    internal class Employee
    {
        public string? name;
        public int age;
        public decimal salary;

        public Employee(string name, int age, decimal salary) {
            this.name = name;
            this.age = age;
            this.salary = salary;
        }

        public void ShowInfo()
        {
            string result = $"Name: {name}, Age: {age}, Salary:{salary}";
            Console.WriteLine(result);
        }
    }
}