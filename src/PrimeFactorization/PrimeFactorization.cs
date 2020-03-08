using System.Collections.Generic;

namespace PrimeFactorization
{
    public class PrimeFactorization
    {
        //implementiert  unter Zuhilfenahme der Musterlösung von https://www.codewars.com/kata/prime-factors-1 und transformiert von Java nach C#
        List<int> primefactorList = new List<int>();

        public List<int> GetPrimeFactors(int i)
        {
            for (int primefactor = 2; i > 1; primefactor++)
            {
                for (; i % primefactor == 0; i /= primefactor)
                {
                    primefactorList.Add(primefactor);
                }
            }
            return primefactorList;
        }
    }
}
