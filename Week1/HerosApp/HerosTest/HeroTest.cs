using System;
using Xunit;
using Heroslib;

namespace HerosTest
{
    public class HeroTest
    {
        Hero testHero = new Hero();
        //[Fact]
        [Theory]
        [InlineData("Unit Testing God")]
        [InlineData("Flying")]
        [InlineData("Lasers Eyes")]
        public void AddSuperPowerShouldAddSuperPower(string superPower)
        { 
            // Arrange (Arranging artifacts that I might need in testing)
            //string superPower = "Unit Testing god";
            
            // Act (Do the thing we wanna test)
            testHero.AddSuperPower(superPower);

            // Assert
            Assert.Equal(superPower, Hero.superPowers.Peek());


        }

        [Theory]
        [InlineData("")]
        [InlineData(null)]
        public void AddSuperPowerShouldThrowArguementException(string superPower){
            // catching exception in unit tests, act and assert are in same step 
            Assert.Throws<ArgumentException>(() => testHero.AddSuperPower(superPower));
        }
    }
}
