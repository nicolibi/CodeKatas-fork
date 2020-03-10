namespace FizzBuzz
{
    public class FizzBuzz
    {
        public string Check(int Inputvalue)
        {
            string returnString = "";


            if (Inputvalue % 3 == 0 && Inputvalue % 5 == 0)
            {
                returnString = "FizzBuzz";

            }
            else if (Inputvalue % 5 == 0)
            {
                returnString = "Buzz";
            }
            else if (Inputvalue % 3 == 0)
            {
                returnString = "Fizz";
            }
            else
            {
                returnString = Inputvalue.ToString();
            }
            return returnString;
        }
    }
}
