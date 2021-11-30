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
        
                
        [Theory]
        [InlineData(100)]
        [InlineData(200)]
        [InlineData(300)]
        public void BeFalseWhenDivisibleBy100ButNotBy400(int year)
        {
            Assert.False(LeapYear.IsLeap(year));
        }
        
        

    }

}