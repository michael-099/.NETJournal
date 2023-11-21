using System;
namespace Palindrome;
class PalindromeCheck
{
    public bool check(string str)
    {
        bool palindrome = true;
        int start = 0;
        int end = str.Length - 1;
        while (end > start)
        {
            if (str[start] == str[end])
            {
                start = start + 1;
                end = end - 1;
            }
            else
            {
                palindrome = false;
                break;
            }

        }
        return palindrome;
    }
}
class program
{
    static void Main(string[] args)
    {
        string str = "abdcba";
        PalindromeCheck palindromeCheck = new PalindromeCheck();
        Console.WriteLine(palindromeCheck.check(str));
    }
}






// Palindrome Check
//Write a C# function that takes a string as input and checks whether it
//is a palindrome or not. A palindrome is a word, phrase, number, or other
//sequence of characters that reads the same forward and backward 
//(ignoring spaces, punctuation, and capitalization).
//[Optional]: Write test for your function
