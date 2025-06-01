namespace Homework8._0;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter any word, to exit, press Q");
        while (true)
        { 
            var input = Console.ReadLine();
            var result = input.ToLower().Replace(" ", "");

            if (string.IsNullOrEmpty(input))
            {
                Console.WriteLine("Enter something!");
                continue;
            }

            if (result == "q")
            {
                Console.WriteLine("Exit");
                break;
            }

            if (result.Length % 2 == 0)
            {
                var firstHalf = result.Substring(0, result.Length / 2);
                var secondHalf = result.Substring(result.Length / 2);
                var symbols = secondHalf.ToCharArray();
                Array.Reverse(symbols);
                var newSecondHalf = new string(symbols);

                if (firstHalf.Equals(newSecondHalf))
                {
                    Console.WriteLine($"The string '{input}' is a palindrome");
                }
                else
                {
                    Console.WriteLine($"The string '{input}' is not a palindrome");
                }
            }

            else if (result.Length % 2 != 0)
            {
                var firstHalf = result.Substring(0, (result.Length / 2) + 1);
                var secondHalf = result.Substring((result.Length / 2));
                var symbols = secondHalf.ToCharArray();
                Array.Reverse(symbols);
                var newSecondHalf = new string(symbols);

                if (firstHalf.Equals(newSecondHalf))
                {
                    Console.WriteLine($"The string '{input}' is a palindrome");
                }
                else
                {
                    Console.WriteLine($"The string '{input}' is not a palindrome");
                }
            } 
        }
    }
}
