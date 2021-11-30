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
        public void BeFalseWhenNotDivisibleByFourHundred()
        {
            Assert.False(LeapYear.IsLeap(399));
        }
        
                
        [Fact]
        public void BeFalseWhenDivisibleBy100ButNotBy400()
        {
            Assert.False(LeapYear.IsLeap(300));
        }

    }

}