using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace dz13
{
    public class PrimeNumbers
    {
        public static IEnumerable<int> GetPrimes(int limit)
        {
            if (limit < 2) yield break;
            yield return 2;

            for (int i = 3; i <= limit; i += 2)
            {
                if (IsPrime(i))
                {
                    yield return i;
                }
            }
        }
        public static IEnumerable<int> GetAllPrimes()
        {
            yield return 2; 

            int number = 3;
            while (true)
            {
                if (IsPrime(number))
                {
                    yield return number;
                }
                number += 2; 
            }
        }


        public static IEnumerable<int> SkipPrimes(int count)
        {
            int skipped = 0;
            foreach (int prime in GetAllPrimes())
            {
                if (skipped >= count)
                {
                    yield return prime;
                }
                skipped++;
            }
        }

        private static bool IsPrime(int a)
        {
            if (a < 2) return false;
            if (a % 2 == 0) return a == 2;
            int x = (int)Math.Sqrt(a);

            for (int i = 3; i <= x; i += 2)
            {
                if (a % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
