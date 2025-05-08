namespace homework3_1;

internal class Program
{
    static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("Enter first boolean value");
            bool firstBool = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("Enter second boolean value");
            bool secondBool = Convert.ToBoolean(Console.ReadLine());

            Console.WriteLine($"B1\t|\tB2\t|\tB1 ^ B2\t|\tB1 && B2\t|\tB1 || B2\t|\t!B1");
            Console.WriteLine(new string('_', 100));
            Console.WriteLine($"\n{firstBool}\t|\t{secondBool}\t" +
                $"|\t{firstBool ^ secondBool}\t|\t{firstBool && secondBool}\t\t" +
                $"|\t{firstBool || secondBool}\t\t|\t{!firstBool}");     
        }
        catch
        {
            Console.WriteLine("Error:\nEnter true or false!");
        }

        Console.ReadKey();
    }
}