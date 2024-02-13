namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input a number");
            try
            {
                NullDividing(Int32.Parse(Console.ReadLine()));
            } catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        static int NullDividing(int input)
        {
            int result = input / 0;
            return result;
        }
    }
}
