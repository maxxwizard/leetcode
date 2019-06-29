using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UniqueMorseCodeWords
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void GinZenGigMsg()
        {
            Assert.AreEqual(2, (new Solution()).UniqueMorseRepresentations(new string[]
                {
                    "gin",
                    "zen",
                    "gig",
                    "msg",
                }));
        }

        [TestMethod]
        public void Empty()
        {
            Assert.AreEqual(0, (new Solution()).UniqueMorseRepresentations(new string[]
                {
                }));
        }
    }
}
