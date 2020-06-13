using System;
using System.Text.RegularExpressions;

namespace CaesarCipher
{
    public class CaesarCipher
    {
        Regex regexSpecialCharactersLowerCase = new Regex("[äöüß]");
        Regex regexSpecialCharacersUpperCase = new Regex("[ÄÖÜ]");
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

        public string Encode(string decryptedString, int shift)
        {
            string encodedString = "";

            decryptedString = ReplaceSpecialCharacters(decryptedString);

            foreach (char c in decryptedString)
            {
                if (Char.IsLetter(c))
                {
                    int shiftedUnicodePosition = GetShiftedPositionOfUnicodeEncode(c, shift);
                    encodedString += GetCharacterFromUnicode(shiftedUnicodePosition);
                }
                else
                {
                    encodedString += c;
                }
            }

            return encodedString;
        }


        public string Decode(string encryptedString, int shift)
        {
            string decodedString = "";

            foreach (char c in encryptedString)
            {
                if (Char.IsLetter(c))
                {
                    int shiftedUnicodePosition = GetShiftedPositionOfCharDecode(c, shift);
                    decodedString += GetCharacterFromUnicode(shiftedUnicodePosition);
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

        private string ReplaceSpecialCharacters(string originalString)
        {
            string replacedString = "";
            if (regexSpecialCharacersUpperCase.IsMatch(originalString))
            {
                replacedString = originalString.Replace("Ä", "Ae").Replace("Ö", "Oe").Replace("Ü", "Ue");
                return replacedString;
            }


            if (regexSpecialCharactersLowerCase.IsMatch(originalString))
            {
                replacedString = originalString.Replace("ä", "ae").Replace("ö", "oe").Replace("ü", "ue").Replace("ß", "ss");
                return replacedString;
            }
            else
            {
                return originalString;
            }




        }

        protected int GetShiftedPositionOfUnicodeEncode(char charToBeEncrypted, int charShift)
        {
            int charPosition = Convert.ToUInt16(charToBeEncrypted);
            shiftedPosition = (charPosition + charShift);


            if (Char.IsLower(charToBeEncrypted))
            {
                int ueberhang = shiftedPosition - MaxPositionLowerCase;
                if (ueberhang > 0)
                {
                    shiftedPostionRotated = (ueberhang - 1) + MinPositionLowerCase;
                    return shiftedPostionRotated;
                }
                else
                {
                    return shiftedPosition;
                }
            }
            else if (char.IsUpper(charToBeEncrypted))
            {
                int ueberhang = shiftedPosition - MaxPositionUpperCase;
                if (ueberhang > 0)
                {
                    shiftedPostionRotated = (ueberhang - 1) + MinPositionUpperCase;
                    return shiftedPostionRotated;
                }
                else
                {
                    return shiftedPosition;
                }

            }
            else
            {
                return shiftedPosition;
            }
        }

        protected int GetShiftedPositionOfCharDecode(char charToBeEncrypted, int charShift)
        {
            int charPosition = Convert.ToUInt16(charToBeEncrypted);
            shiftedPosition = (charToBeEncrypted - charShift);

            if (Char.IsLower(charToBeEncrypted))
            {
                int ueberhang = shiftedPosition - MinPositionLowerCase;
                if (ueberhang < 0)
                {
                    shiftedPostionRotated = ((ueberhang + 1) + MaxPositionLowerCase);
                    return shiftedPostionRotated;
                }
                else
                {
                    return shiftedPosition;
                }


            }
            else if (char.IsUpper(charToBeEncrypted))
            {
                int ueberhang = shiftedPosition - MinPositionUpperCase;
                if (ueberhang < 0)
                {
                    shiftedPostionRotated = ((ueberhang + 1) + MaxPositionUpperCase);
                    return shiftedPostionRotated;
                }
                else
                {
                    return shiftedPosition;
                }

            }
            return shiftedPostionRotated;
        }



    }
}

