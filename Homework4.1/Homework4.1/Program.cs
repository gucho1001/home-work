namespace Homework4._1;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("All two-digit numbers are multiples of 5:");
        for (var count = -99; count <= 99; count++)
        {
            if (count % 5 == 0)
            {
                if (count <= -10 || count >= 10)
                {
                    Console.Write(" " + count);
                }
            }
        }

        Console.ReadKey();
    }
}