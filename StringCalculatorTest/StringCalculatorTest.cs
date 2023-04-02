using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using StringCalculatorProject;

namespace StringCalculatorTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Add_Test()
        {
            //Arrange 
            int expected = 0;

            //Act
            var numbers = new StringCalculator();
            int actual = numbers.Add("");

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
