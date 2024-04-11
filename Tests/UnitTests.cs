using System;
using NUnit.Framework;

namespace GithubActionsLab
{
    [TestFixture]
    public class Math
    {
        [Test]
        public void Add_Valid()
        {
            Assert.AreEqual(3, Program.Add("1", "2"));
            Assert.AreEqual(5, Program.Add("3", "2"));
            Assert.AreEqual(12, Program.Add("5", "7"));
        }

        [Test]
        public void Add_Invalid()
        {
            Assert.Throws<FormatException>(() => Program.Add("1", "a"));
            Assert.Throws<FormatException>(() => Program.Add("a", "1"));
            Assert.Throws<FormatException>(() => Program.Add("a", "a"));
        }

        [Test]
        public void Add_Null()
        {
            Assert.Throws<ArgumentNullException>(() => Program.Add("1", null));
            Assert.Throws<ArgumentNullException>(() => Program.Add(null, "1"));
            Assert.Throws<ArgumentNullException>(() => Program.Add(null, null));
        }

        // Implement 3 tests per operation, following a similar pattern as above
        [Test]
        public void Power_ValidPositiveExponent()
        {
            Assert.AreEqual(1, Program.Power("1", "0"), "1^0 should be 1");
            Assert.AreEqual(9, Program.Power("3", "2"), "3^2 should be 9");
            Assert.AreEqual(3125, Program.Power("5", "5"), "5^5 should be 3125");
        }

        [Test]
        public void Power_ValidNegativeExponent()
        {
            
            Assert.AreEqual(1, Program.Power("10", "-0"), 0.0001, "10^-0 should be 1");
            Assert.AreEqual(0.04, Program.Power("5", "-2"), 0.0001, "5^-2 should be 0.04");
        }

        [Test]
        public void Power_ZeroBase()
        {
            Assert.AreEqual(0, Program.Power("0", "5"), "0^5 should be 0");
            Assert.Throws<DivideByZeroException>(() => Program.Power("0", "-1"), "0^-1 should throw DivideByZeroException");
        }

        [Test]
        public void Power_Invalid()
        {
            Assert.Throws<FormatException>(() => Program.Power("1", "a"), "Exponent is not a number");
            Assert.Throws<FormatException>(() => Program.Power("a", "1"), "Base is not a number");
            Assert.Throws<FormatException>(() => Program.Power("a", "b"), "Both base and exponent are not numbers");
        }

        [Test]
        public void Power_Null()
        {
            Assert.Throws<ArgumentNullException>(() => Program.Power("1", null), "Exponent is null");
            Assert.Throws<ArgumentNullException>(() => Program.Power(null, "1"), "Base is null");
            Assert.Throws<ArgumentNullException>(() => Program.Power(null, null), "Both base and exponent are null");
        }
    }
}
