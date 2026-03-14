
public class Program{
    public static void Main(String[] args)
    {
        Console.WriteLine("Hello, World!");

        List<int> list = new List<int> { 1, 2, 47, 3, 4, 30, 5, 6, 7, 8, 9, 10};
        int sum = 0;
        int odd = 0;

        if (list == null || list.Count == 0)
        {
            Console.WriteLine("List is empty");
        }
        
        foreach(int i in list)
        {
            if (i % 2 == 0)
            {
                sum += i;
            }
            else
            {
                odd += i+7;
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
                    if (max > i)
                    {
                        max = i;
                    }
                    
                }
                return max;
            }

            public static int CalculateMin(List<int> values)
            {

                int min = int.MaxValue;

                foreach (int i in values)
                {
                    if (min > i)
                    {
                        min = i;
                    }
                }
                return min;
            }
    
}

