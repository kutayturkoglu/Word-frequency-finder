using System;
using System.Collections.Generic;

namespace Text
{
    internal class GetInput
    {
        internal void Text()
        {
            while (true)
            {
                try
                {

                    Console.WriteLine("Enter the first string: ");                    
                    string text1 = Console.ReadLine().ToLower();
                    if(string.IsNullOrWhiteSpace(text1))
                    {
                        throw new Exception("Please enter a string: ");
                    } 

                    Console.WriteLine("Enter the second string: ");
                    string text2 = Console.ReadLine().ToLower();
                    if(string.IsNullOrWhiteSpace(text2))
                    {
                        throw new Exception("Please enter a string: ");
                    }

                    Console.WriteLine("Enter the third string ");
                    string text3 = Console.ReadLine().ToLower();
                    if(string.IsNullOrWhiteSpace(text3))
                    {
                        throw new Exception("Please enter a string: ");
                    }

                    string finalText = text1 + " " + text2 + " " + text3;

                    MyList<string> myList = new MyList<string>();
                    myList = myList.Tokenize(finalText, myList); 

                    MyHash<string> myHash = new MyHash<string>();
                    myHash = myHash.Push(myList, myHash);

                    MyTable<string, int> myTable = new MyTable<string, int>();
                    myTable.Push(myList, myHash, myTable);

                    break;
                }
                catch(Exception e)
                {
                    Console.WriteLine(e);
                }
                
            }
        }
    }
}