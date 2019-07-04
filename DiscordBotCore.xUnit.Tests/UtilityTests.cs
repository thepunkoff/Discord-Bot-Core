using Xunit;

namespace DiscordBotCore.xUnit.Tests
{
    public class UtitilyTests
    {
        [Fact]
        public void MyFirstTest()
        {
            const int expected = 5;

            var actual = Utilities.MyUtility(expected);

            Assert.Equal(expected, actual);
        }
    }
}
