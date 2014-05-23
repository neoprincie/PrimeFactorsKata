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
            var potentialPrime = 2;

            while(n > 1)
            {
                while (n % potentialPrime == 0)
                {
                    n /= potentialPrime;
                    primeFactors.Add(potentialPrime);
                }

                potentialPrime++;
            }
            
            return primeFactors;
        }
    }
}
