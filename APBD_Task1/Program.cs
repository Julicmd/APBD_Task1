
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
        
        int avg = CalculateAvg(list);
        Console.WriteLine("Average of even numbers: "+avg);
        
    }
public static int CalculateAvg(List<int> num)
            {
                int sum = 0;
                int count = 0;
                int avg = 0;
                foreach (int  i in num )
                {
                    sum += i;
                    count++;
                    
                }
                avg = sum / count;
                return avg;
                
            }

            public static int CalculateMax(List<int> values)
            {
                int max = 0;
                foreach (int i in values)
                {
                    if (max < i)
                    {
                        max = i;
                    }
                    
                }
                return max;
            }
    
}

