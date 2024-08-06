using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AdvancedCsharp_Assignment3
{
    internal class CustomList <T>
    {
        private List<T>? elements;

        public CustomList()
        {
            elements = new List<T>();
        }

        public void Add(T element) { 

            elements?.Add(element);
        }
        

        // 1● Exist
        public  bool Exist (Predicate<T> match)
        {
            // 1 - Check if match is NUll
            if (match == null)
            {
                throw new ArgumentNullException(nameof(match));
            }

            foreach (T element in elements )
            {
                if (match(element))
                {
                    return true;
                }

            }
            return false;

        }

        //●	Find

        public T Find(Predicate<T> match) {

            if (match == null)
            {
                throw new ArgumentNullException(nameof(match));
            }
            

            for (int i = 0; i < elements?.Count; i++)

            {
                if (match(elements[i]))
                {
                    return elements[i];
                }
                
            }

            return default (T);
        }



        // FindALL
        public List<T> FindAll (Predicate<T> match)
        {
            List<T> FoundedElements = new List<T> ();

            if (match == null)
            {
                throw new ArgumentNullException(nameof(match));
            }


            for (int i = 0; i < elements?.Count; i++)

            {
                if (match(elements[i]))
                {
                    FoundedElements.Add( elements[i]);
                }

            }

            return FoundedElements;
        }

        //●	Find index 

        public  int FindIndex (Predicate<T> match)
        {

            if (match == null)
            {
                throw new ArgumentNullException(nameof(match));
            }


            for (int i = 0; i < elements?.Count; i++)

            {
                if (match(elements[i]))
                {
                    return i ;
                }

            }

            return -1;
        }

        public int FindIndex(int StartIndex,Predicate<T> match)
        {

            if (match == null)
            {
                throw new ArgumentNullException(nameof(match));
            }


            for (int i = StartIndex; i < elements?.Count; i++)

            {
                if (match(elements[i]))
                {
                    return i;
                }

            }

            return -1;
        }


        //●	Find Last

        public T FindLast (Predicate<T> match)
        {

            if (match == null)
            {
                throw new ArgumentNullException(nameof(match));
            }
            T elementLast = default ;

            for (int i = 0; i < elements?.Count; i++)

            {
                if (match(elements[i]))
                {
                    elementLast = elements[i];
                }

            }

            return elementLast;
        }



        //●	Find Last Index
        public int FindLastIndex (Predicate<T> match)
        {

            if (match == null)
            {
                throw new ArgumentNullException(nameof(match));
            }
            int elementLastIndex = default;

            for (int i = 0; i < elements?.Count; i++)

            {
                if (match(elements[i]))
                {
                    elementLastIndex = i;
                }

            }

            return elementLastIndex;
        }


        //●	Foreach
        public void ForEach (Action<T> action)
        {
            if (action == null)
            {
                throw new ArgumentNullException(nameof(action));
            }

            foreach(T element in elements)
                action.Invoke(element);

            
        }

        public bool TrueForAll(Predicate<T> match)
        {
            if (match == null)
            {
                throw new ArgumentNullException(nameof(match));
            }
            
            foreach (T element in elements)
            {
                if (!match.Invoke(element))
                {
                    return false;
                
                }
            }
            return true;
               


        }






    }

}


