namespace AdvancedCsharp_Assignment3
{

    public delegate string GetTitleDelegate (Book book);
    public delegate string[] GetAuthoursDelegate(Book book);
    public delegate decimal GetPriceDelegate(Book book);

    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            List<Book> books = new List<Book>()
            {
                new Book("1", "The Sun", new[] { "Ahmed" }, new DateTime(2034, 1, 1), 3000),
                new Book("2", "The MOON", new[] { "Soso" }, new DateTime(2024, 1, 1), 4000),

            };

            foreach (Book book in books)
                Console.WriteLine(book);
            //c)Anonymous Method (GetISBN).
            //Func<Book, string> GetISBN = delegate (Book book) { return book.ISBN ?? "No ISBN"; };
            //d)Lambda Expression (GetPublicationDate).
            //Func<Book, DateTime> GetPublicationDate = (book) => (book.PublicationDate);

            Console.WriteLine("\n ==========");
            LibraryEngine.ProcessBook<string>(books, BookFunctions.GetTitle);
            Console.WriteLine("\nProcessing ISBNs:");
            LibraryEngine.ProcessBook<string>(books, delegate (Book book) { return book.ISBN ?? "No ISBN"; });
            Console.WriteLine("\nProcessing Publication Date:");
            LibraryEngine.ProcessBook<DateTime>(books, (book) => (book.PublicationDate)); 
            #endregion




            #region Q2:2.We need to Implement the List methods from scratch with all overloads.

            #endregion
        }
    }
}
