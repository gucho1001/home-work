namespace Homework4._2;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("The sequence of numbers is -20, -40, ...,-100:\n");
        var count = 0;
        do
        {
            count--;
            if (count % 20 == 0)
            {
                Console.WriteLine(count);
            }
        }
        while (count >= -100);

        Console.ReadKey();
    }
}