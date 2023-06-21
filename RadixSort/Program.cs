using RadixSort;

public class Program
{
    public static void Main(string[] args)
    {
        int[] numbers = { 170, 45, 75, 90, 802, 24, 2, 66 };
        Console.WriteLine("Массив:");
        PrintArray(numbers);

        LSDSort.Sort(numbers);
        Console.WriteLine("\nМассив отсортирован LSD:");
        PrintArray(numbers);

        string[] strings = { "banana", "apple", "elderberry", "date", "cherry", "fig" };
        Console.WriteLine("\nМассив:");
        PrintArray(strings);

        MSDSort.Sort(strings);
        Console.WriteLine("\nМассив отсортирован MSD:");
        PrintArray(strings);
    }

    private static void PrintArray<T>(T[] arr)
    {
        foreach (T item in arr)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }
}