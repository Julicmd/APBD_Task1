
public class Program{
    public static void Main(String[] args)
    {
        Console.WriteLine("Hello, World!");

        List<int> list = new List<int> { 1, 2, 3, 4, 5, 6, 7};
        int sum = 0;

        foreach(int i in list)
        {
            sum += i;
        }
        Console.WriteLine("Sum of numbers: "+sum);

    }
}

