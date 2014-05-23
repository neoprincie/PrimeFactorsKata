using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeFactorsKata
{
    public class PrimeFactors
    {
        public List<int> Generate(int n)
        {
            var primeFactors = new List<int>();

            while (n % 2 == 0)
            {
                n /= 2;
                primeFactors.Add(2);
            }
            if (n != 1)
                primeFactors.Add(n);

            return primeFactors;
        }
    }
}
