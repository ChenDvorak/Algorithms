using Algorithms.BreadthFilstSearch;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace AlgorithmsTest.LeetCode
{
    [TestClass]
    public class LetterCombinationsOfPhoneNumberTest
    {
        [TestMethod]
        public void TestLetterCombinationsOfPhoneNumber()
        {
            var f = new Algorithms.LeetCode.LetterCombinationsOfPhoneNumber();
            var combinations = f.Run("23").ToArray();
            Assert.IsTrue(combinations.SequenceEqual(new string[] { "ad", "ae", "af", "bd", "be", "bf", "cd", "ce", "cf" }));
        }
    }
}