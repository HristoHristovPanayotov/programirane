namespace Method
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            SignOfIntegerNumbers(n);
        }
        static void SignOfIntegerNumbers(int numbers)
        {
            numbers = int.Parse(Console.ReadLine());
            if (numbers > 0)
            {
                Console.WriteLine($"The number {numbers} is positive.");
            }
            else if (numbers == 0)
            {
                Console.WriteLine($"The number {numbers} is zero.");
            }
            else if (numbers < 0)
            {
                Console.WriteLine($"The number {numbers} is negative.");

            }

        }
    }
}