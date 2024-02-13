using System.Diagnostics;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int result = 0;

            foreach (int x in nums)
            {
                result += x;
                Console.WriteLine(result);
            }

            List<int> list = new List<int>(nums);

            List<int> list2 = new List<int>();

            var input = from i in list
                        where i %2 == 0
                        select i;
            
            Console.WriteLine("LINQ MOMENT");
            foreach (var item in input)
            {
                Console.WriteLine(item);
            }   
           
            Console.ReadKey();
        }
    }
}
