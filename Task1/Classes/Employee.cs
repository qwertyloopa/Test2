using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.Classes
{
    internal class Employee : IComparable<Employee>
    {
        public string? name;
        public int age;
        public decimal salary;

        public Employee(string name, int age, decimal salary) {
            this.name = name;
            this.age = age;
            this.salary = salary;
        }

        public virtual void ShowInfo()
        {
            string result = $"Name: {name}, Age: {age}, Salary:{salary}";
            Console.WriteLine(result);
        }

        public int CompareTo(Employee? other)
        {
            if (other == null) return 1 ;
            return salary.CompareTo(other.salary) ;
        }
        
    }
}
