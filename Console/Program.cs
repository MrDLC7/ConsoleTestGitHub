class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Test GitHub!");
        Console.WriteLine("Test develop!");
        Console.ReadKey();
        const int d = 81;
        Console.WriteLine($"Test {d * d}");
        Test(d);
        Console.ReadKey();
    }
    static void Test(int i)
    {
        for (int j = 1; j < i; j++)
        {
            Console.Write(j + " ");
            if (j % 20 == 0) Console.WriteLine(",");
        }
    }
}