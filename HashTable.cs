using System;
using System.Collections.Generic;

namespace Text
{
    internal class MyHash<T> : HashSet<T>
    {
        internal MyHash<string> Push(MyList<T> myList, MyHash<string> myHash)
        {
            foreach (var item in myList)
            {
                if(myHash.Contains(Convert.ToString(item)) == false)
                {
                    myHash.Add(Convert.ToString(item));
                }
            }
            Write(myHash);
            return myHash;
        }

        private void Write(MyHash<string> myHash)
        {
            Console.WriteLine("\nThis string contains" + myHash.Count + " different words in it.");
            Console.WriteLine("Word List");
            foreach (var item in myHash)
            {
                Console.WriteLine(Convert.ToString(item));
            }
        }
    }
}