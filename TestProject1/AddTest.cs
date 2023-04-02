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
            int expected = 5;

            //Act
            var numbers = new StringCalculator();
            int actual = numbers.Add("2,3");

            //Assert
            Assert.Equal(expected, actual);
        }
    }
}


 