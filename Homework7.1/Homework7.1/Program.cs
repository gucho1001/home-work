namespace Homework7._1;

internal class Program
{
    static void Main(string[] args)
    {
        var rnd = new Random();
        var array = new int[3, 3];
        Console.WriteLine("Random array:");

        for (var i = 0; i < array.GetLength(0); i++)
        {
            for (var j = 0; j < array.GetLength(1); j++)
            {

                array[i, j] = rnd.Next(0, 10);
                Console.Write(array[i, j] + " ");
            }
            Console.WriteLine();
        }

        for (var i = 0; i < array.GetLength(0); i++)
        {
            var max = array[i, 0];
            for (var j = 0; j < array.GetLength(1); j++)
            {
                if (max < array[i, j])
                {
                    max = array[i, j];
                }
            }
            Console.WriteLine($"The maximum number in the {i + 1} row: {max}");
        }
    }
}
