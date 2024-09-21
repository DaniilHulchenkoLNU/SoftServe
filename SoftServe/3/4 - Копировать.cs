using System.Collections.Generic;

public static class IListExtensions
{
    public static void IncreaseWith(this IList<int> list, int value)
    {
        for (int i = 0; i < list.Count; i++)
        {
            list[i] += value;
        }
    }
}

public static class IEnumerableExtensions
{
    public static string ToString<T>(this IEnumerable<T> sequence)
    {
        return "[" + string.Join(", ", sequence) + "]";
    }
}

class Program
{
    static void Main()
    {
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };

        // Output the original list
        Console.WriteLine(numbers.ToString());

        // Increase each number by 5
        numbers.IncreaseWith(5);

        // Output the modified list
        Console.WriteLine(numbers.ToString());
    }
}
