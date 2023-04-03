using System;
using StringCalculatorProject;

namespace TestProject
{
    public class StringCalculatorTests
    {
        [Theory]
        [InlineData("2\n3,1,5", new char[] { ',', '\n' })]
        [InlineData("2;3;1;5", new char[] { ';' })]
        public void Add_Test(string nums, char[] deli)
        {
            //Arrange 
            int expected = 11;

            //Act
            var numbers = new StringCalculator();
            int actual = numbers.Add(nums, deli);

            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
