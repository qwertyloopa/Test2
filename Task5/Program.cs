namespace Task5
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<int> numbers = new List<int>();
            for (int i = 0; i <= 1000; i++)
            {
                numbers.Add(i);
            }

            Thread evenThread = new Thread(() => PrintEven(numbers));
            Thread oddThread = new Thread(() => PrintOdd(numbers));

            evenThread.Start();
            oddThread.Start();

            evenThread.Join();
            oddThread.Join();

            Console.WriteLine("Программа завершена");
        }

        static void PrintEven(List<int> numbers)
        {
            lock (numbers)
            {
                foreach (int number in numbers)
                {
                    if (number % 2 == 0)
                    {
                        Console.WriteLine($"Четное число: {number}");
                        Thread.Sleep(50);
                    }
                }
            }
        }

        static void PrintOdd(List<int> numbers)
        {
            lock (numbers)
            {
                foreach (int number in numbers)
                {
                    if (number % 2 == 1)
                    {
                        Console.WriteLine($"Нечетное число: {number}");
                        Thread.Sleep(50);
                    }
                }
            }
        }
    }
}
