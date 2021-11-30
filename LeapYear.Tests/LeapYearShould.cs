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
        
        [Theory]
        [InlineData(400)]
        [InlineData(800)]
        [InlineData(2000)]
        public void BeTrueWhenDivisibleBy100And400(int year)
        {
            Assert.True(LeapYear.IsLeap(year));
        }
        
        
        
        [Theory]
        [InlineData(2004)]
        [InlineData(2008)]
        [InlineData(2012)]
        public void BeTrueWhenDivisibleBy4ButNotBy100(int number)
        {
            Assert.True(LeapYear.IsLeap(number));
        }
        
        

    }

}