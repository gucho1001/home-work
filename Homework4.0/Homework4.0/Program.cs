namespace Homework4._0;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter size of array (0-100)");
        int input;
        while (true)
        {
            if (int.TryParse(Console.ReadLine(), out input))
            {
                if (input >= 0 && input <= 100)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Error: Enter size of array (0-100)");
                }
            }
            else
            {
                Console.WriteLine("Error: input number!");
            }
        }
        int[] array = new int[input];
        var count = 0;
        Random rnd = new Random();

        Console.WriteLine("\nCycle while:");
        while (count < array.Length)
        {
            array[count] = rnd.Next(100);
            Console.Write(array[count] + " ");
            count++;
        }

        Console.WriteLine("\n\nCycle for with foreach:");
        for (count = 0; count < array.Length; count++)
        {
            array[count] = rnd.Next(100);
        }

        foreach (int i in array)
        {
            Console.Write(i + " ");
        }

        Console.WriteLine("\n\nCycle do while:");
        count = 0;
        if (array.Length > 0)
        {
            do
            {
                array[count] = rnd.Next(100);
                Console.Write(array[count] + " ");
                count++;
            }
            while (count < array.Length);
        }
        Console.ReadKey();
    }
}