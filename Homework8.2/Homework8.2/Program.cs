namespace Homework8._2;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter any string");
        while (true)
        {
            var input = Console.ReadLine().ToLower();
            var symb = input.ToCharArray();

            if (string.IsNullOrEmpty(input))
            {
                Console.WriteLine("Enter something");
                continue;
            }

            for (var i = 0; i < symb.Length; i++)
            {
                if (i == 0 || (i > 0 && symb[i - 1] == ' '))
                {
                    symb[i] = char.ToUpper(symb[i]);
                }
            }

            Console.WriteLine("Result:\n" + input.Trim());
            Console.WriteLine(input.ToUpper().Trim());
            Console.WriteLine(new string(symb).Trim());
            break;
        }
    }
}
