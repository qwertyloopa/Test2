using Task1.Classes;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee john = new Employee("John", 28, 1200);
            //john.ShowInfo();

            Manager lily = new Manager("Lily", 25, 3000, "Marketing");
            //lily.ShowInfo();

            List<Employee> list = new List<Employee> { john, lily };
            list.Sort();

            foreach (Employee e in list)
            {
                e.ShowInfo();
            }
        }
    }
}
