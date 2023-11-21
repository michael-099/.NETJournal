using System;
namespace String_count;
class StringCount
{
    public Dictionary<char, int> Count = new Dictionary<char, int>();
    public void addToDic(string s)
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
    public void PrintCount(Dictionary<char, int> Count)
    {
        foreach (var x in Count)
        {
            Console.WriteLine($"{x.Key}:{x.Value}");
        }
    }
//    static void Main(string[] args){   
//         string s="hello world";
//         StringCount stringCount = new StringCount();
//         stringCount.addToDic(s);
//         stringCount.PrintCount(stringCount.Count);


//     }
}
class program{
 static void Main(string[] args)
    {   
        string s="hello world";
        StringCount stringCount = new StringCount();
        stringCount.addToDic(s);
        stringCount.PrintCount(stringCount.Count);


    }
}

// Task:  Word Frequency Count
// Write a C# function that takes a string as input and returns a
//  dictionary containing the frequency of each word in the string.
//   Treat words in a case-insensitive manner and ignore punctuation marks.
// [Optional]: Write test for your function
