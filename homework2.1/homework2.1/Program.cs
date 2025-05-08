namespace homework2_1;

internal class Program
{
    static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("Enter first number");
            var firstNumb = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter second number");
            var secondNumb = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"Sum: {firstNumb + secondNumb}");
            Console.WriteLine($"Difference: {firstNumb - secondNumb}");
            Console.WriteLine($"Multiplication: {firstNumb * secondNumb}");
            Console.WriteLine("Division: " + (secondNumb != 0 ? firstNumb / secondNumb : "Error"));
        }
        catch
        {
            Console.WriteLine("Error:\nEnter a number!");
        }

        Console.ReadKey();

    }
}