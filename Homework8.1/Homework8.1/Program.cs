using System.Text;
using System.Transactions;

namespace Homework8._1;

internal class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Enter any string, to exit, enter Q");
            var input = Console.ReadLine();

            if (input == "q")
            {
                Console.WriteLine("Exit");
                break;
            }

            if (string.IsNullOrEmpty(input))
            {
                Console.WriteLine("Enter anything");
                continue;
            }

            var sb = new StringBuilder(input);
            sb.Replace(" ", "");

            Console.WriteLine(sb.ToString());
        }
    }
}
