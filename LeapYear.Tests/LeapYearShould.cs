using Xunit;

namespace LeapYear.Tests
{

    public class LeapYearShould
    {
        [Fact]
        public void BeTrueWhenDivisibleByFourHundred()
        {
            Assert.True(LeapYear.IsLeap(2000));
        }
    }

}