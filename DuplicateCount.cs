public class DuplicateCount
{

    public void CountDuplicate(int[]arr)
    {
        int count = 0;
        
        for(int j = 0; j < arr.Length-1; j++)
        {
            for (int i = j+1; i < arr.Length; i++)
            {
                if (arr[j] == arr[i])
                {
                    count++;
                }
            }
        }

        Console.WriteLine($"Count of duplicate element is : {count}");
       
    }
    static void Main()
    {
        int size;
        Console.WriteLine("Enter Size");
        size = int.Parse(Console.ReadLine());
        int[] arr = new int[size];
        for(int i = 0; i<size;i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }
        DuplicateCount d = new DuplicateCount();
        d.CountDuplicate(arr);

    }
}