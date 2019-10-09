using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Take_a_Ten_Minute_Walk;

namespace UnitTest.Take_a_Ten_Minute_Walk
{
    [TestClass]
    public class SolutionTest
    {
        [TestMethod]
        public void SampleTest()
        {
            Assert.AreEqual(true, Kata.IsValidWalk(new string[] { "n", "s", "n", "s", "n", "s", "n", "s", "n", "s" }), "should return true");
            Assert.AreEqual(false, Kata.IsValidWalk(new string[] { "w", "e", "w", "e", "w", "e", "w", "e", "w", "e", "w", "e" }), "should return false");
            Assert.AreEqual(false, Kata.IsValidWalk(new string[] { "w" }), "should return false");
            Assert.AreEqual(false, Kata.IsValidWalk(new string[] { "n", "n", "n", "s", "n", "s", "n", "s", "n", "s" }), "should return false");
        }
    }
}
