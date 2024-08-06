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
            // Exist

            Predicate<Book> mactchPrice = book => book.Price > 1000;
            CustomList<Book> booksList = new CustomList<Book>();
            booksList.Add(new Book("1", "The Sun", new[] { "Ahmed" }, new DateTime(2034, 1, 1), 3000));
            booksList.Add(new Book("10", "Sky", new[] { "Ahmed ,Wael" }, new DateTime(2010, 1, 1), 3456));
            booksList.Add(new Book("105", "Sky", new[] { "Ahmed ,Wael" }, new DateTime(2010, 1, 1), 1000));
            booksList.Add(new Book("125", "So", new[] { "omar ,Wael" }, new DateTime(2010, 1, 1), 1000));
            booksList.Add(new Book("1234", "E", new[] { "gog ,Wael" }, new DateTime(2010, 1, 1), 14000));






            bool exist = booksList.Exist(mactchPrice);
            Console.WriteLine($"Is there book that it's Price > 1000 : ({exist})");
            Console.WriteLine("\n==============");
            Book Sky= booksList.Find(book => book.Title == "Sky");
            Console.WriteLine($"Found Book = {Sky}");
            Console.WriteLine("\n==============");

            List<Book> FoundedBooks = booksList.FindAll(book => book.Title == "Sky");
            foreach (Book book in FoundedBooks) Console.WriteLine(book);

            Console.WriteLine($"Index = {booksList.FindIndex(book => book.Price == 3000)}");
        
            Console.WriteLine($"Index start from 2 = { booksList.FindIndex(2, book => book.Price > 3000)}");
            Console.WriteLine("\n==============");
            Console.WriteLine($"The last book which its price = 1000 is : {booksList.FindLast(book => book.Price ==1000)}");
            Console.WriteLine("\n==============");
            Console.WriteLine($"TrueForAll : {booksList.TrueForAll(book => book.Price %2 ==1)}");



            #endregion

        }
    }
}
