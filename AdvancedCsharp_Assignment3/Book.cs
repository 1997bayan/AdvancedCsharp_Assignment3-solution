using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedCsharp_Assignment3
{
    public class Book
    {

        public string? ISBN { get; set; }
        public string? Title { get; set; }
        public string[]? Aauthors { get; set; }
        public DateTime PublicationDate { get; set; }
        public decimal Price { get; set; }
        public Book(string? iSBN, string? title, string[]? _authors, DateTime publicationDate, decimal price)
        {
            ISBN = iSBN;
            Title = title;
            Aauthors = _authors;
            PublicationDate = publicationDate;
            Price = price;
        }



        public override string ToString()

        {
            string authorString = Aauthors != null ? string.Join(", ", Aauthors) : "NotValid";
            return $"Book ISBN : {ISBN} , Title : {Title} , Aauthors :{authorString} , Publication Date : {PublicationDate} ," +
                $"Book Price : {Price}";
        }

    }


    


}


   

