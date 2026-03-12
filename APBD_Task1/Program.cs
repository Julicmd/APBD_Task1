
public class Program{
    public static void Main(String[] args)
    {
        Console.WriteLine("Hello, World!");

        List<int> list = new List<int> { 1, 2, 3, 4, 5, 6, 7};
        int sum = 0;
        
        foreach(int i in list)
        {
            if (i % 2 == 0)
            {
                sum += i;
            }
        }
        Console.WriteLine("Sum of even numbers: "+sum);

    }

    public int CalculateAvg(List<int> num)
    {
        
    }
}

