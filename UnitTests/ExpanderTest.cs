using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ExpandedEnglish;

namespace ExpandedEnglish.UnitTests
{
    [TestClass]
    public class ExpanderTest
    {
        private IExpander expander = new Expander();

        [TestMethod]
        public void TestExpand()
        {
            var testExpand = expander.Expand("Often I wish for tomorrow.");
            Assert.AreEqual("Ofeleven I wish five threemorrow.", testExpand);
        }

        [TestMethod]
        public void TestCaps()
        {
            var testExpand = expander.Expand("Ten should be capitalized.");
            Assert.IsTrue(char.IsUpper(testExpand, 0));
        }

        [TestMethod]
        public void TestLowerCase()
        {
            var testExpand = expander.Expand("for should be lowercase.");
            Assert.IsFalse(char.IsUpper(testExpand, 0));
        }
    }
}
