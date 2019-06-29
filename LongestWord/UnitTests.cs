using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LongestWord
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void Apple()
        {
            var trie = new Trie(new string[]
            {
                "a",
                "banana",
                "app",
                "appl",
                "ap",
                "apply",
                "apple",
            });

            Assert.AreEqual("apple", trie.getLongestWord());
        }

        [TestMethod]
        public void Latte()
        {
            var trie = new Trie(new string[]
            {
                "m", "mo", "moc", "moch", "mocha", "l", "la", "lat", "latt", "latte", "c", "ca", "cat",
            });

            Assert.AreEqual("latte", trie.getLongestWord());
        }

        [TestMethod]
        public void yodn()
        {
            var trie = new Trie(new string[]
            {
                "yo", "ew", "fc", "zrc", "yodn", "fcm", "qm", "qmo", "fcmz", "z", "ewq", "yod", "ewqz", "y"
            });

            Assert.AreEqual("yodn", trie.getLongestWord());
        }

        [TestMethod]
        public void B()
        {
            var trie = new Trie(new string[]
            {
                "b",
            });

            Assert.AreEqual("b", trie.getLongestWord());
        }

        [TestMethod]
        public void Empty()
        {
            var trie = new Trie(new string[]
            {
            });

            Assert.AreEqual("", trie.getLongestWord());
        }
    }
}
