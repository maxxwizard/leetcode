using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MultiplyTwoIntegers
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Iterative()
        {
            Assert.AreEqual(8, Solution.multiplyIterative(2, 4));
            Assert.AreEqual(6, Solution.multiplyIterative(2, 3));
            Assert.AreEqual(24, Solution.multiplyIterative(6, 4));
        }

        [TestMethod]
        public void Recursive()
        {
            Assert.AreEqual(8, Solution.multiplyRecursive(2, 4));
            Assert.AreEqual(6, Solution.multiplyRecursive(2, 3));
            Assert.AreEqual(24, Solution.multiplyRecursive(6, 4));
        }
    }
}
