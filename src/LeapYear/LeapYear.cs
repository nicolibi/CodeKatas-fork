namespace LeapYear
{
    public class LeapYear
    {
        public bool IsLeapYear(int i)
        {

            // ergänzt am 1.3.20
            if (i >= 8 && i % 4 == 0)
            {
                if (i % 100 == 0)
                {
                    if (i % 400 == 0)
                        return true;
                    else
                        return false;
                }
                else
                    return true;
            }

            else if (i >= -45 && i <= -9)
            {
                if (i % 3 == 0)
                    return true;
                else
                    return false;

            }
            //keine Schaltjahre zwischen 10 BC und 8 AD
            else if (i >= -10 && i < 8)
            {
                //Sonderregelung für Jahr Null einfügen
                if (i == 0)
                {
                    throw new System.ArgumentException("Year 0 didn't exist");

                }
                else
                {
                    return false;
                }
            }

            else if (i < -46)
            {
                return false;
            }

            else
            {
                return false;
            }
        }
    }
}
