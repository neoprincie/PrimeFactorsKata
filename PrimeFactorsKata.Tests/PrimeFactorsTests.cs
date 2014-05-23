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
        private PrimeFactors primeFactors;

        [SetUp]
        public void SetUp()
        {
            primeFactors = new PrimeFactors();
        }

        [Test]
        public void Generate_Given1_ShouldReturnEmpty()
        {
            Assert.That(primeFactors.Generate(1), Is.EquivalentTo(new List<int>()));
        }

        [Test]
        public void Generate_Given2_ShouldReturn2()
        {
            Assert.That(primeFactors.Generate(2), Is.EquivalentTo(new List<int>() { 2 }));
        }

        [Test]
        public void Generate_Given3_ShouldReturn3()
        {
            Assert.That(primeFactors.Generate(3), Is.EquivalentTo(new List<int>() { 3 }));
        }

        [Test]
        public void Generate_Given4_ShouldReturn2and2()
        {
            Assert.That(primeFactors.Generate(4), Is.EquivalentTo(new List<int>() { 2, 2 }));
        }

        [Test]
        public void Generate_Given5_ShouldReturn5()
        {
            Assert.That(primeFactors.Generate(5), Is.EquivalentTo(new List<int>() { 5 }));
        }
    }
}
