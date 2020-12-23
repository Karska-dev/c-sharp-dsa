using System;

namespace ValidPalindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "A man, a plan, a canal: Panama";
            Console.WriteLine($"Is \"{str}\" a palindrome?");
            Console.WriteLine(IsPalindrome(str));

        }
        static bool IsPalindrome(string s)
        {
            if (s == string.Empty) return true;
            s = s.ToLower();
            int start = 0;
            int end = s.Length - 1;
            while (start < end)
            {
                if (!char.IsLetterOrDigit(s[start])) start++;
                else if (!char.IsLetterOrDigit(s[end])) end--;
                else if (s[start++] != s[end--])
                {
                    return false;
                }
            }
            return true;
        }
        // just in case
        static bool IsAlphanumeric(char ch)
        {
            int number = (int)ch;
            if (number > 64 && number < 90) number += 32;
            if (number < 60 || number > 122 || ( number > 57 && number < 97))
            {
                return false;
            }
            return true;
        }
    }
}
