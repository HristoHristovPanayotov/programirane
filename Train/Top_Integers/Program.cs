namespace Top_Integers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
            .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            for (int i = 0; i < arr.Length; i++)
            {
                int chislo = arr[i];
                bool topN = true;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    int chislo2 = arr[j];
                    if (chislo2 >= chislo)
                    {
                        topN = false;
                        break;
                    }
                }
                if (topN)
                {
                    Console.Write($"{chislo} ");
                }
            }
        }
    }
}