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
        
        [Fact]
        public void BeFalseWhen399()
        {
            Assert.False(LeapYear.IsLeap(399));
        }
    }

}