using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedCsharp_Assignment3
{
    public class BookFunctions
    {

        public static string GetTitle(Book B)
        {
            return B.Title ?? "No title";

        }

        public static string[] GetAuthours(Book B)
        {
            return B.Aauthors ?? new string[0];
        }

        public static decimal GetPrice(Book B)
        {
            return B.Price;

        }


    }
}
