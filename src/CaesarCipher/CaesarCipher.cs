using System;
using System.Text.RegularExpressions;

namespace CaesarCipher
{
    public class CaesarCipher
    {
        Regex regexitemLowerCase = new Regex("[a-z]");
        Regex regexitemUpperCase = new Regex("[A-Z]");
        const int MinPositionUpperCase = 65;
        const int MaxPositionUpperCase = 90;
        const int MinPositionLowerCase = 97;
        const int MaxPositionLowerCase = 122;
        private int shiftedPosition = 0;
        private int shiftedPostionRotated = 0;
        public enum Operation
        {
            encode,
            decode
        }

        public string Encode(string s, int shift)
        {
            string encodedString = "";
            foreach (char c in s)
            {
                if (regexitemLowerCase.IsMatch(c.ToString()) || regexitemUpperCase.IsMatch(c.ToString()))
                {
                    int unicode = GetUnicodeFromChar(c);
                    int shiftedUnicodePosition = GetShiftedPositionOfUnicodeEncode(unicode, shift);
                    encodedString += GetCharacterFromUnicode(shiftedUnicodePosition);
                }
                else
                {
                    encodedString += c;
                }
            }

            return encodedString;
        }


        public string Decode(string s, int shift)
        {
            string decodedString = "";

            foreach (char c in s)
            {
                if (regexitemLowerCase.IsMatch(c.ToString()) || regexitemUpperCase.IsMatch(c.ToString()))
                {
                    int unicode = GetUnicodeFromChar(c);
                    //int shiftedUnicodePosition = GetShiftedPositionOfUnicode(unicode, shift, Operation.decode);
                    decodedString += GetCharacterFromUnicode(unicode + shift);
                }
                else
                {
                    decodedString += c;
                }
            }

            return decodedString;
        }


        protected int GetUnicodeFromChar(char character)
        {
            int unicode = Convert.ToUInt16(character);
            return unicode;
        }

        protected char GetCharacterFromUnicode(int unicode)
        {
            return Convert.ToChar(unicode);
        }

        protected int GetShiftedPositionOfUnicodeEncode(int unicodeOld, int charShift)
        {

            shiftedPosition = (unicodeOld + charShift);


            if (unicodeOld > MinPositionLowerCase && shiftedPosition > MaxPositionLowerCase)
            {
                shiftedPostionRotated = ((shiftedPosition - MinPositionLowerCase) % 26) + MinPositionLowerCase;
                return shiftedPostionRotated;
            }
            else if (unicodeOld > MinPositionUpperCase && unicodeOld < MaxPositionUpperCase && shiftedPosition > MaxPositionUpperCase)
            {
                shiftedPostionRotated = ((shiftedPosition - MinPositionUpperCase) % 26) + MinPositionUpperCase;
                return shiftedPostionRotated;
            }
            else
            {
                return shiftedPosition;
            }
        }

        protected int GetShiftedPositionOfUnicodeDecode(int unicodeOld, int charShift)
        {

            shiftedPosition = (unicodeOld - charShift);

            if (unicodeOld > MinPositionLowerCase && shiftedPosition > MaxPositionLowerCase)
            {
                shiftedPostionRotated = ((shiftedPosition - MinPositionLowerCase) % 26) + MinPositionLowerCase;
                return shiftedPostionRotated;
            }
            else if (unicodeOld > MinPositionUpperCase && shiftedPosition > MaxPositionUpperCase)
            {
                shiftedPostionRotated = ((shiftedPosition - MinPositionUpperCase) % 26) + MinPositionUpperCase;
                return shiftedPostionRotated;
            }
            else
            {
                return shiftedPosition;
            }
        }

    }
}

