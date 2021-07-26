# Word Frequency Finder
This is a basic Natural Language Processing command line project written in C# which gets 3 sentences from the user as an input and processes the words according to their frequencies.
Throughout this project, Generics are used to process the data which are obtained by the user in string format. As a beginning, 3 sentences are asked from the user and combine those three sentences in 1 sentence to make the process faster and easier. After obtaining the final sentence, sentences are tokenized into words and stored in a generic list named as myList. After storing the data in myList, the size of the List is written to a console to find the total word frequency and all the words in the final sentence. After finding the sentences, the members of myList are pushed into a Generic HashTable named as myHash and in *HashTable.cs* file, frequencies of each word are obtained. Afterwards, members of myList and myTable are pushed into a Dictionary Generic named as MyTable and with the help of a dictionary, a word|frequency table is written into the console and found the most used word throughout the whole sentences.
