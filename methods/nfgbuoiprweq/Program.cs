namespace Greater_of_Two_Values
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            GetMax(type);
        }
        static void GetMax(string type)
        {

            switch (type)
            {
                case "int":

                    int a = int.Parse(Console.ReadLine());
                    int b = int.Parse(Console.ReadLine());

                    if (a > b)
                    {
                        Console.WriteLine(a);
                    }
                    else
                    {
                        Console.WriteLine(b);
                    }


                    break;

                case "char":

                    char c = char.Parse(Console.ReadLine());
                    char d = char.Parse(Console.ReadLine());

                    if (c < d)
                    {
                        Console.WriteLine(d);
                    }
                    else
                    {
                        Console.WriteLine(c);
                    }

                    break;

                case "string":
                    string e = Console.ReadLine();
                    string f = Console.ReadLine();
                    int result = string.Compare(e, f);

                    if (result > 0)
                    {
                        Console.WriteLine(e);
                    }
                    else if (result < 0)
                    {
                        Console.WriteLine(f);
                    }

                    break;
            }
        }
    }
}