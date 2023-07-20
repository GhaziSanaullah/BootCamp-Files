//NAMWE:GHAZI SANAULLAH
//STUDENT ID: 4830

using System;
using System.Collections.Generic;

namespace myproject
{
    class Program
    {
        static string[] Storesentence() // Changed the return type to string[]
        {
            string s = Console.ReadLine()!;
            s = s.ToLower();//reference-https://www.geeksforgeeks.org/c-sharp-tolower-method/
            //reference for below approach-https://learn.microsoft.com/en-us/dotnet/api/system.string.split?view=netframework-4.8
            char[] separators = new char[] { ' ', ',', '!', ';', '.', '?', ':', '*', '+', '=', '@', '#', '%', '(', ')', '_', '/', '"' };//the sentence input is split based on these punctuation marks and spaces
            string[] wordarray = s.Split(separators, System.StringSplitOptions.RemoveEmptyEntries); //this line splits the sentence based on the split parameters defined before and if after splitting null array entry is created it is removed
            return wordarray;
        }
        static void Frequency(string[] words)
        {
            Dictionary<string, int> dict = new Dictionary<string, int>();//reference for this line-https://www.loginradius.com/blog/engineering/how-to-create-and-use-dictionary-csharp/
            //i am using dictionary because i can easily add each word only 1 times in it. it also helps in storing the word and any associated value with it too such as wordlength
            foreach (var word in words)
            {
                if (dict.ContainsKey(word))
                {
                    dict[word]++;// block of code checks if the array entry is present in the dictionary as a key. if it is present it increments the value of that entry(key).
                }
                else
                {
                    dict[word] = 1;// this block of code check if array entry is present in the dictionary as a key. if it is not present it adds that array entry and initialises its value to 1.
                }
            }
            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine("Words and their Frequency Report: ");
            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine();
            foreach (var entry in dict)
            {
                Console.WriteLine(entry.Key + " occurs " + entry.Value + " times in the sentence.");//this line transverses through the dictionary and prints each key and its value
            }
            Console.WriteLine();
        }
        static void Sentencemaker(string[] array)
        {
            Random rnd = new Random();//it will help in creating random array index
            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine("Enter the number of sentences you want to print: ");
            Console.WriteLine("----------------------------------------------------------");
            int sentences = int.Parse(Console.ReadLine()!);
            Console.WriteLine();
            Console.WriteLine("The sentences are printed below: ");
            Console.WriteLine();
            int arrayindex;
            for (int i = 1; i <= sentences; i++)
            {
                for (int j = 1; j <= 5; j++)
                {
                    arrayindex = rnd.Next(0, array.Length);//loop iterates 5 times and each time a random array index is generated from 0 to array length
                    Console.Write(array[arrayindex] + " ");
                }
                Console.WriteLine();
            }
        }
        static void Longandshortword(string[] words)
        {
            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine("Largest and smallest word Report. ");
            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine();
            Dictionary<string, int> dict = new Dictionary<string, int>();
            foreach (var word in words)
            {
                if (dict.ContainsKey(word))
                {
                    continue;
                }
                else
                {
                    dict.Add(word, word.Length);
                }
            }

            List<string> largestword = new List<string>();//reference-https://www.c-sharpcorner.com/UploadFile/mahesh/create-a-list-in-C-Sharp/
            List<string> smallestword = new List<string>();
            int largestwordlength = 0;
            int smallestwordlength = 10000000;
            Console.WriteLine();
            foreach (var word in dict)
            {
                if (word.Value > largestwordlength)
                {
                    largestwordlength = word.Value;
                    largestword.Clear();//reference-https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1?view=net-7.0
                    //if a greater word is found it clears the previous list to add the new word which is done in next line
                    largestword.Add(word.Key);
                }
                else if (word.Value == largestwordlength)//if a word of similar length is found it then adds that word to the list too. helps in getting more then 1 words of same length
                {
                    largestword.Add(word.Key);
                }
            }
            Console.WriteLine("Largest word/words found in the sentence: ");
            Console.WriteLine();
            foreach (var word in largestword)
            {
                Console.Write(word + " ");
            }
            Console.WriteLine();
            Console.WriteLine();
            foreach (var word in dict)
            {
                if (word.Value < smallestwordlength)
                {
                    smallestwordlength = word.Value;
                    smallestword.Clear();
                    smallestword.Add(word.Key);
                }
                else if (word.Value == smallestwordlength)
                {
                    smallestword.Add(word.Key);
                }
            }
            Console.WriteLine("Smallest word/words found in the sentence: ");
            Console.WriteLine();
            foreach (var word in smallestword)
            {
                Console.Write(word + " ");
            }
            Console.WriteLine();
        }
        static void Wordsearch(string[] words)
        {
            Console.WriteLine();
            Dictionary<string, int> dict = new Dictionary<string, int>();
            foreach (var word in words)
            {
                if (dict.ContainsKey(word))//same code as used in frequency function
                {
                    dict[word]++;
                }
                else
                {
                    dict[word] = 1;
                }
            }
            bool isfound = false;//if no word is found this flag remains false and prints no word statement
            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine("Enter the word you want to search in the sentence: ");
            Console.WriteLine("----------------------------------------------------------");
            string searchword = Console.ReadLine()!;
            foreach (var word in dict)
            {
                if (word.Key == searchword)
                {
                    Console.WriteLine(word.Key + " occurs " + word.Value + " times in the sentence.");
                    isfound = true;
                    break;
                }
            }
            if (!isfound)//this means if the value of flag is false
            {
                Console.WriteLine();
                Console.WriteLine("The entered word is not found in the sentence. ");
            }
            Console.WriteLine();
        }
        static void Palindormedetector(string[] words)
        {
            Console.WriteLine();
            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine("Palindrome Report.");
            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine();
            Dictionary<string, int> dict = new Dictionary<string, int>();
            foreach (var word in words)
            {
                if (dict.ContainsKey(word))
                {
                    continue;
                }
                else
                {
                    dict.Add(word, 0);
                }
            }
            string wordtocheck = "";
            string reversedword = "";
            int counter = 0;//this counter is assigned the value of wordlength
            bool palindromeflag = false;
            foreach (var word in dict)
            {
                wordtocheck = word.Key;
                counter = wordtocheck.Length;
                reversedword = "";//i initialised the reversed word to empty so in each iteration new word can be stored in it
                for (int i = counter - 1; i >= 0; i--)
                {
                    reversedword = reversedword + wordtocheck[i];
                }
                if (wordtocheck == reversedword && counter > 1)// i added this counter==1 because if it is 1 letter word program also counts it as palindrome.
                {
                    Console.WriteLine(wordtocheck + " is a palindrome word in the sentence.");
                    palindromeflag = true;
                }
            }
            if (!palindromeflag)
            {
                Console.WriteLine("There is no palindorme found in the sentence. ");
            }
            Console.WriteLine();
        }
        static void Vowelconsonantcounter(string[] words)
        {
            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine("Vowels and Consonants Report ");
            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine();
            Dictionary<string, int> dict = new Dictionary<string, int>();
            foreach (var word in words)
            {
                if (dict.ContainsKey(word))
                {
                    continue;//this continues that iteration of the loop if the words is already present. it helps in not storing the same word multiple times if it occurs multiple times in the sentence
                }
                else
                {
                    dict.Add(word, 0);
                }
            }
            int vowelcounter = 0;
            int consonantcounter = 0;
            string wordchecked = "";
            foreach (var word in dict)
            {
                wordchecked = word.Key;
                vowelcounter = 0;
                consonantcounter = 0;
                foreach (char c in wordchecked)
                {
                    if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u')
                    {
                        vowelcounter++;
                    }
                    else
                    {
                        consonantcounter++;
                    }
                }
                Console.WriteLine(word.Key + " has " + vowelcounter + " vowels and " + consonantcounter + " consonants. ");
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            string[] sentenceWords = new string[0]; // Empty array to store sentence words
            Console.WriteLine("Enter a new sentence.");
            sentenceWords = Storesentence();

            while (true)//refrence-https://www.guru99.com/c-sharp-conditional-statements.html
            {
                Console.WriteLine("____________________________________________________________________");
                Console.WriteLine("Choose an option:");
                Console.WriteLine("1. Enter a new sentence.");
                Console.WriteLine("2. Word Frequency Analysis");
                Console.WriteLine("3. Sentence Maker");
                Console.WriteLine("4. Longest and Shortest Word Finder");
                Console.WriteLine("5. Word Search");
                Console.WriteLine("6. Palindrome Detector");
                Console.WriteLine("7. Vowel/Consonant Counter");
                Console.WriteLine("8. If you want the full text report.");
                Console.WriteLine("9. Exit");

                string choice = Console.ReadLine()!;

                switch (choice)//i can use multiple if and else if statements here but upon searching i found switch which better helps in taking user input and deciding which part to execute based on it
                {
                    case "1":
                        sentenceWords = Storesentence();
                        break;
                    case "2":
                        Frequency(sentenceWords);
                        break;
                    case "3":
                        Sentencemaker(sentenceWords);
                        break;
                    case "4":
                        Longandshortword(sentenceWords);
                        break;
                    case "5":
                        Wordsearch(sentenceWords);
                        break;
                    case "6":
                        Palindormedetector(sentenceWords);
                        break;
                    case "7":
                        Vowelconsonantcounter(sentenceWords);
                        break;
                    case "8":
                        {
                            Frequency(sentenceWords);
                            Longandshortword(sentenceWords);
                            Palindormedetector(sentenceWords);
                            Vowelconsonantcounter(sentenceWords);
                            Sentencemaker(sentenceWords);
                            Wordsearch(sentenceWords);
                            break;
                        }
                    case "9":
                        Console.WriteLine("Exiting the program...");
                        return;// this statements returns a value and end the while loop too if its condition is set to True. It ends the entire main method
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }

                Console.WriteLine(); // Empty line for readability
            }
        }
    }
}