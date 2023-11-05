using System.Security.Cryptography.X509Certificates;

namespace Multiply_Evens_by_Odds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int result = GetMultipleOfEvenAndOdd(n);
            Console.WriteLine(result);
        }

        static int GetMultipleOfEvenAndOdd(int n)
        {
            int evenS = GetSumOfEvenDigits(n);
            int oddS = GetSumOfOddDigits(n);
            return evenS * oddS;
        }

        static int GetSumOfEvenDigits(int n)
        {
            int sum = 0;
            n = Math.Abs(n);
            while (n > 0)
            {
                int d = n % 10;
                if (d % 2 == 0)
                {
                    sum += d;
                }
                n /= 10;
            }
            return sum;
        }

        static int GetSumOfOddDigits(int n)
        {
            int sum = 0;
            n = Math.Abs(n);
            while (n > 0)
            {
                int d = n % 10;
                if (d % 2 != 0)
                {
                    sum += d;
                }
                n /= 10;
            }
            return sum;
        }
    }
}