using Microsoft.VisualStudio.TestTools.UnitTesting;
using BalancedBracketsNS;

namespace BalancedBracketsTests
{
    [TestClass]
    public class BalancedBracketsTests

        /**
         * Test for True on valid strings
         */
    {
        // First test given by the studio instructions
        [TestMethod]
        public void OnlyBracketsReturnsTrue()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("[]"));
        }

        [TestMethod]
        public void EmptyStringReturnsTrue()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets(""));
        }

        [TestMethod]
        public void BracketsContainingTextReturnsTrue()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("[Text]"));
        }

        [TestMethod]
        public void BracketsBeforeTextReturnsTrue()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("[]Text"));
        }

        [TestMethod]
        public void BracketsAfterTextReturnsTrue()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("Text[]"));
        }

        [TestMethod]
        public void TextBeforeInAndAfterBracketsReturnsTrue()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("Text[text]text"));
        }

        [TestMethod]
        public void NestedBracketsReturnTrue()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("[[test[0]][1][2]]"));
        }

        /** 
         * Test for False on  "[LaunchCode", "Launch]Code[", "[", "]["
         */
    

        [TestMethod]
        public void NoClosingBracketReturnsFalse()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("[LaunchCode"));
        }

        [TestMethod]
        public void ReversedBracketsInTextReturnsFalse()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("Launch]Code["));
        }

        [TestMethod]
        public void SingleOpenBracketReturnsFalse()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("["));
        }

        [TestMethod]
        public void SingleClosingBracketReturnsFalse()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("]"));
        }

        [TestMethod]
        public void ReversedBracketsReturnsFalse()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("]["));
        }
    }
}
