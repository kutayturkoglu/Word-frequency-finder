using System;
using System.Collections.Generic;

namespace Text
{
    internal class MyTable<T1, T2> : SortedDictionary<string, int>
    {
        internal void Push(MyList<string> myList, MyHash<string> myHash, MyTable<string, int> myTable)
        {
            foreach(var item in myHash)
            {
                int counter = 0;
                for(int i = 0; i < myList.Count; ++i)
                {
                    if(myList[i] == item)
                    {
                        ++counter;
                    }
                }
                myTable.Add(item, counter);
            }
            Write(myTable);
        }
        private void Write(MyTable<string, int> myTable)
        {
            Console.WriteLine("\nFrequency table of the words: ");
            Console.WriteLine("Words\t\nFrequencies");
            foreach(var item in myTable)
            {
                Console.WriteLine(Convert.ToString(item.Key + "\t\t" + item.Value));
            }
            Max(myTable);
        }
        private void Max(MyTable<string, int> myTable)
        {
            int max = 0;
            Console.WriteLine("\nThe most repeated word:");
            foreach(var item in myTable)
            {
                if(item.Value > max)
                {
                    max = item.Value;
                }
            }
            foreach(var item in myTable)
            {
                if(item.Value == max)
                {
                    Console.WriteLine(item.Key + "\t\t" + item.Value);
                    break;
                }
                break;
            }
        }
    } 
}