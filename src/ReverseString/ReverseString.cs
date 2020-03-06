using System;

namespace ReverseString
{
    public class ReverseString
    {
        public string Reverse(string s)
        {
            char[] CharList = s.ToCharArray();
            Array.Reverse(CharList);
            return new string(CharList);
        }
    }
}
