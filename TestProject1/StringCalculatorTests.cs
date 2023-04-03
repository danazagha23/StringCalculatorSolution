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
            int expected = 11;

            //Act
            var numbers = new StringCalculator();
            int actual = numbers.Add("2\n3,1,5");

            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
