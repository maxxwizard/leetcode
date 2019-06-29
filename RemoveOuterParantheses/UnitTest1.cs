using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RemoveOuterParantheses
{
    [TestClass]
    public class UnitTest1
    {
        [DataTestMethod]
        [DataRow("()()", "")]
        [DataRow("(()())(())", "()()()")]
        [DataRow("(()())(())(()(()))", "()()()()(())")]
        public void DataTests(string input, string expected)
        {
            Assert.AreEqual(expected, (new Solution()).RemoveOuterParentheses(input));
        }
    }
}
