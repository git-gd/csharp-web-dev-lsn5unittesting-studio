using Microsoft.VisualStudio.TestTools.UnitTesting;
using BalancedBracketsNS;

namespace BalancedBracketsTests
{
    [TestClass]
    public class BalancedBracketsTests
    {
        // First test given by the studio instructions
        [TestMethod]
        public void OnlyBracketsReturnsTrue()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("[]"));
        }

        [TestMethod]
        public void EmptyStringReturnsFalse()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets(""));
        }

        [TestMethod]
        public void NullStringReturnsFalse()
        {
            string nullStr = null;

            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets(nullStr));
        }
    }
}
