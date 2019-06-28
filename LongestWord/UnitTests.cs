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

            Assert.AreEqual(trie.getLongestWord(), "apple");
        }

        [TestMethod]
        public void Latte()
        {
            var trie = new Trie(new string[]
            {
                "m", "mo", "moc", "moch", "mocha", "l", "la", "lat", "latt", "latte", "c", "ca", "cat",
            });

            Assert.AreEqual(trie.getLongestWord(), "latte");
        }

        [TestMethod]
        public void yodn()
        {
            var trie = new Trie(new string[]
            {
                "yo", "ew", "fc", "zrc", "yodn", "fcm", "qm", "qmo", "fcmz", "z", "ewq", "yod", "ewqz", "y"
            });

            Assert.AreEqual(trie.getLongestWord(), "yodn");
        }

        [TestMethod]
        public void B()
        {
            var trie = new Trie(new string[]
            {
                "b",
            });

            Assert.AreEqual(trie.getLongestWord(), "b");
        }

        [TestMethod]
        public void Empty()
        {
            var trie = new Trie(new string[]
            {
            });

            Assert.AreEqual(trie.getLongestWord(), "");
        }
    }
}
