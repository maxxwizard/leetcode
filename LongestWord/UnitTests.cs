using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LongestWord
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void Apple()
        {
            Assert.AreEqual("apple", new Solution().LongestWord(new string[]
            {
                "a",
                "banana",
                "app",
                "appl",
                "ap",
                "apply",
                "apple",
            }));
        }

        [TestMethod]
        public void Latte()
        {
            Assert.AreEqual("latte", new Solution().LongestWord(new string[]
            {
                "m", "mo", "moc", "moch", "mocha", "l", "la", "lat", "latt", "latte", "c", "ca", "cat",
            }));
        }

        [TestMethod]
        public void yodn()
        {
            Assert.AreEqual("yodn", new Solution().LongestWord(new string[]
            {
                "yo", "ew", "fc", "zrc", "yodn", "fcm", "qm", "qmo", "fcmz", "z", "ewq", "yod", "ewqz", "y"
            }));
        }

        [TestMethod]
        public void B()
        {
            Assert.AreEqual("b", new Solution().LongestWord(new string[]
            {
                "b",
            }));
        }

        [TestMethod]
        public void Empty()
        {
            Assert.AreEqual("", new Solution().LongestWord(new string[]
            {
            }));
        }
    }
}
