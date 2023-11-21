using System;
namespace String_count;
class StringCount
{
    Dictionary<char, int> Count = new Dictionary<char, int>();
    void addToDic(string s)
    {
        for (int i = 0; i < s.Length; i++)
        {
            if (Count.ContainsKey(s[i]))
            {
                Count[s[i]] = Count[s[i]] + 1;
            }
            else
            {
                Count.Add(s[i], 1);
            }

        }

    }
    void PrintCount()
    {
        foreach (var x in Count)
        {
            Console.WriteLine($"{x.key}:{x.value}");
        }
    }
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome");
    }
}


// Task:  Word Frequency Count
// Write a C# function that takes a string as input and returns a
//  dictionary containing the frequency of each word in the string.
//   Treat words in a case-insensitive manner and ignore punctuation marks.
// [Optional]: Write test for your function
