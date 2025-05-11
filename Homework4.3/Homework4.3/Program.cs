namespace Homework4._3;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Figure control: w - up, s - down, a - left, d - right");
        Console.WriteLine("Press 'q' to the end the game");
        while (true)
        {
            var input = Console.ReadLine().ToLower();
            switch (input)
            {
                case "w":
                    Console.WriteLine("Figure moved up");
                    break;
                case "s":
                    Console.WriteLine("Figure moved down");
                    break;
                case "a":
                    Console.WriteLine("Figure moved left");
                    break;
                case "d":
                    Console.WriteLine("Figure moved right");
                    break;
                case "q":
                    Console.WriteLine("Exit this 'game'");
                    return;
                default:
                    Console.WriteLine("you have pressed an invalid key");
                    break;
            }
        }
    }
}