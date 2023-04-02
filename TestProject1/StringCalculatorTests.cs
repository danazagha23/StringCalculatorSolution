using System;
using StringCalculatorProject;

namespace TestProject
{
    public class StringCalculatorTests
    {
        [Fact]
        public void Add_Test()
        {
            //Arrange 
            int expected = 10;

            //Act
            var numbers = new StringCalculator();
            int actual = numbers.Add("2,3,4,1");

            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
