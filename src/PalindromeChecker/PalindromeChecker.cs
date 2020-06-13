using System;

namespace PalindromeChecker
{
    public class PalindromeChecker
    {
        char[] charList;
        public bool IsPalindrome(string s)
        {

            if (s != null)
            {
                charList = s.ToCharArray();
                Array.Reverse(charList);
            }

            if (s == new string(charList) || s == null)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
