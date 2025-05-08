namespace HomeWork2_0;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(" Enter your name");
        var name = Console.ReadLine();
        if(name.Trim() == "")
        {
            Console.WriteLine("Error:\nEnter a name!");
            Environment.Exit(0);
        }
        try
        {
            Console.WriteLine(" Enter your age");
            var age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" Enter your height");
            var height = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"Hello, {name}!");
            Console.WriteLine($"\tYour age: {age} years.");
            Console.WriteLine($"\t\tYour height: {height}.");
        }
        catch
        {
            Console.WriteLine("Error:\nEnter a number!");
        }
        

        Console.ReadKey();
    }
}