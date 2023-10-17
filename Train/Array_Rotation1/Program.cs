namespace Array_Rotation1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] arr = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse)
            .ToArray();

            int chislo = int.Parse(Console.ReadLine());

            for (int i = 0; i < chislo; i++)
            {
                for (int j = arr.Length - 1; j >= 0; j--)
                {
                    int element = arr[arr.Length - 1];
                    arr[arr.Length - 1] = arr[j];
                    arr[j] = element;

                }
            }
            Console.WriteLine(string.Join(" ", arr));

        }
    }
}