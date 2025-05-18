namespace Homework5
{
    internal class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int Pages { get; set; }

        public Book()
        {
            Title = "Unknown";
            Author = "Unknown";
            Pages = 0;
        }
        public Book(string title, string author, int pages)
        {
            Title = title;
            Author = author;
            Pages = pages;
        }

        public string GetDescription()
        {
            return $"Title: {Title},\nAuthor: {Author},\nPages: {Pages}.\n";
        }
    }
}
