using System;
using Xunit;

namespace Leap_year_function.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            //Arrange
            var notleapyear1 = Program.IsLeapYear(1700);
            var notleapyear2 = Program.IsLeapYear(1800);
            var notleapyear3 = Program.IsLeapYear(1900);
            var actualleapyear1 = Program.IsLeapYear(1600);
            var actualleapyear2 = Program.IsLeapYear(2000);
            //Act
            
            //Assert
            Assert.False(notleapyear1);
            Assert.False(notleapyear2);
            Assert.False(notleapyear3);
            Assert.True(actualleapyear1);
            Assert.True(actualleapyear2);
        
        }
    }
}
