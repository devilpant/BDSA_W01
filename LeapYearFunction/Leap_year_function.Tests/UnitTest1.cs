using System;
using Xunit;
using System.IO;

namespace Leap_year_function.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void IsLeapYear_test()
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
        [Fact]
        public void console_test_yay(){
            //Arrange
            var writer = new StringWriter();
            Console.SetOut(writer);

            var input = new StringReader("1600");
            Console.SetIn(input);

            //Act
            Program.Main(new string[0]);

            //Assert
            var output = writer.GetStringBuilder().ToString().Trim();
            Assert.Equal("yay", output);
        }
        [Fact]
        public void console_test_nay(){
            //Arrange
            var writer = new StringWriter();
            Console.SetOut(writer);

            var input = new StringReader("1800");
            Console.SetIn(input);

            //Act
            Program.Main(new string[0]);

            //Assert
            var output = writer.GetStringBuilder().ToString().Trim();
            Assert.Equal("nay", output);
        }

        [Fact]
        public void Error_handling_test(){
            //Arrange
            var writer = new StringWriter();
            Console.SetOut(writer);

            var input = new StringReader("1500");
            Console.SetIn(input);

            //Act
            Program.Main(new string[0]);

            //Assert
            var output = writer.GetStringBuilder().ToString().Trim();
            Assert.Equal("This only applies to years from 1582", output);
        }
    }
}
