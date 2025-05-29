namespace Homework7._0;

internal class Program
{
    static void Main(string[] args)
    {
        var array = new int[6];
        var rnd = new Random();
        var sort = 0;
        Console.WriteLine("Random array:");

        for (var i = 0; i < array.Length; i++)
        {
            array[i] = rnd.Next(0, 10);
            Console.Write(array[i] + " ");
        }

        for (var i = 0; i < array.Length - 1; i++)
        {
            for (var j = 0; j < array.Length - i - 1; j++)
                if (array[j] < array[j + 1])
                {
                    sort = array[j];
                    array[j] = array[j + 1];
                    array[j + 1] = sort;
                }
        }
        Console.WriteLine("\nSorted array in descending order:");

        foreach (var item in array)
        {
            Console.Write(item + " ");
        }
    }
}
