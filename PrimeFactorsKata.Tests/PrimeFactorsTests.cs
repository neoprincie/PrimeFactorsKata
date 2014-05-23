using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeFactorsKata.Tests
{
    [TestFixture]
    public class PrimeFactorsTests
    {
        [Test]
        public void Generate_Given1_ShouldReturnEmpty()
        {
            var primeFactors = new PrimeFactors();
            Assert.That(primeFactors.Generate(1), Is.EquivalentTo(new List<int>()));
        }
    }
}
