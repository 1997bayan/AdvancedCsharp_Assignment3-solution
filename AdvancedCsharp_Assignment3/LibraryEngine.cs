using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedCsharp_Assignment3
{
    public delegate T Fptr<T>(Book book);
    public class LibraryEngine
    {
        public static void ProcessBook<T> (List<Book> books ,Fptr<T> Process )
        {
            foreach (Book book in books)
            {  
                Console.WriteLine(Process.Invoke(book));

            }
        }
    }
}
