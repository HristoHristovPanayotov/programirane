namespace Math_Power
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());
            int p = int.Parse(Console.ReadLine());
            Console.WriteLine(Math.Pow(n, p));
        }
        static double RaisedToPower(double number, int power)
        {
            double result = 0;
            return result += Math.Pow(number, power); ;
        }
    }
}