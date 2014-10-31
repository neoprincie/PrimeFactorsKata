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

        [Test]
        public void Generate_Given6_ShouldReturn2and3()
        {
            Assert.That(primeFactors.Generate(6), Is.EquivalentTo(new List<int>() { 2, 3 }));
        }

        [Test]
        public void Generate_Given7_ShouldReturn7()
        {
            Assert.That(primeFactors.Generate(7), Is.EquivalentTo(new List<int>() { 7 }));
        }

        [Test]
        public void Generate_Given8_ShouldReturn2and2and2()
        {
            Assert.That(primeFactors.Generate(8), Is.EquivalentTo(new List<int>() { 2, 2, 2 }));
        }

        [Test]
        public void Generate_Given9_ShouldReturn3and3()
        {
            Assert.That(primeFactors.Generate(9), Is.EquivalentTo(new List<int>() { 3, 3 }));
        }

        [Test]
        public void Generate_Given10_ShouldReturn5and2()
        {
            Assert.That(primeFactors.Generate(10), Is.EquivalentTo(new List<int>() { 5, 2 }));
        }
    }
}
