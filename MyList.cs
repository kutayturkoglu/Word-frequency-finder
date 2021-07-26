using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Text
{
    internal class MyList<T>: List<T> 
    {
        internal MyList<string> Tokenize(string finalText, MyList<string> myList)
        {
            string[] tempArr = Regex.Split(finalText, @"[^a-zA-Z\d]");
            foreach(var item in tempArr)
            {
                if(string.IsNullOrWhiteSpace(Convert.ToString(item)) == false)
                {
                    myList.Add(item);
                }
            }
            myList = SubListWrite(myList);
            return myList;
        }

        private MyList<string> SubListWrite(MyList<string> myList)
        {
            Console.WriteLine("\nTotal amount of words in the list:  " + myList.Count);
            foreach (var item in myList)
            {
                Console.WriteLine(item);
            }
            return(myList);
        }


    }
}