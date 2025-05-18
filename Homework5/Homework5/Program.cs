namespace Homework5;

internal class Program
{
    static void Main(string[] args)
    {
        var bookOne = new Book
        {
            Title = "Harik v Pote",
            Author = "Vitalya NKVD",
            Pages = 228
        };

        var bookTwo = new Book("The Black Lord", "Tolik", 322);

        Console.WriteLine(bookOne.GetDescription());
        Console.WriteLine(bookTwo.GetDescription());
    }
}
