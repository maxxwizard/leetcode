using Microsoft.VisualStudio.TestTools.UnitTesting;

/// <summary>
/// https://www.youtube.com/watch?v=qli-JCrSwuk
/// </summary>
namespace NumberOfWaysDecodeMessage
{
    [TestClass]
    public class UnitTest1
    {
        public int NumWays(string data)
        {
            int[] memo = new int[data.Length+1];
            return Helper(data, data.Length, memo);
        }

        private int Helper(string data, int k, int[] memo)
        {
            if (k == 0)
                return 1;

            int index = data.Length - k;
            if (data[index] == '0')
                return 0;

            if (memo[k] != 0)
            {
                return memo[k];
            }

            int result = Helper(data, k - 1, memo);
            if (k >= 2 && int.Parse(data.Substring(index, 2)) <= 26)
            {
                result += Helper(data, k - 2, memo);
            }

            memo[k] = result;
            return memo[k];
        }

        [TestMethod]
        public void NumWays_UnitTests()
        {
            Assert.AreEqual(
                NumWays(""),
                1);

            Assert.AreEqual(
                NumWays("011"),
                0);

            // ab
            // l
            Assert.AreEqual(
                NumWays("12"),
                2);

            // ba
            // u
            Assert.AreEqual(
                NumWays("21"),
                2);

            // abcde
            // lcde
            // awde
            Assert.AreEqual(
                NumWays("12345"),
                3);

            // bgcde
            Assert.AreEqual(
                NumWays("27345"),
                1);
        }
    }
}
