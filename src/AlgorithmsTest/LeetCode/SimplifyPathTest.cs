using Algorithms.BreadthFilstSearch;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace AlgorithmsTest.LeetCode
{
    [TestClass]
    public class SimplifyPathTest
    {
        [TestMethod]
        public void TestSimplifyPath()
        {
            var f = new Algorithms.LeetCode.SimplifyPath();
            Assert.AreEqual(f.Run("/home/"), "/home");
            Assert.AreEqual(f.Run("/../"), "/");
            Assert.AreEqual(f.Run("/home//foo/"), "/home/foo");
            Assert.AreEqual(f.Run("/a/./b/../../c/"), "/c");
            Assert.AreEqual(f.Run("/a/../../b/../c//.//"), "/c");
            Assert.AreEqual(f.Run("/a//b////c/d//././/.."), "/a/b/c");
        }
    }
}