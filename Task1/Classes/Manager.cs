using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.Classes
{
    internal class Manager : Employee
    {
        public string department;
        public Manager(string name, int age, decimal salary, string department) : base(name, age, salary)
        {
            this.department = department;
        }

        public override void ShowInfo()
        {
            string result = $"Name: {name}, Age: {age}, Salary:{salary}, Department: {department}";
            Console.WriteLine(result);
        }
    }
}
