namespace LeapYear
{
    public class LeapYear
    {
        public bool IsLeapYear(int i)
        {
            if (i % 4 == 0)
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
            else
            {
                return false;
            }
        }
    }
}
