using System;
using Models;
using Xunit;

namespace Tests
{
    public class ModelTests
    {
        [Fact]
        public void CustomerNameShouldSetValidData()
        {
            Customer test = new Customer();
            string testName = "test name";

            test.Name = testName;

            Assert.Equal(testName, test.Name);
        }

        [Theory]
        [InlineData("")]
        [InlineData("$*#!")]
        [InlineData("3514_")]
        public void CustomerShouldNotAllowInvalidName(string input)
        {
            Customer test = new Customer();

            Assert.Throws<InputInvalidException>(() => test.Name = input);
        }

        [Theory]
        [InlineData("")]
        [InlineData("$*#!@#$%")]
        [InlineData(" 123@yahoo.com")]
        public void CustomerShouldNotAllowInvalidEmail(string input)
        {
            Customer test = new Customer();

            Assert.Throws<InputInvalidException>(() => test.Email = input);
        }
    }
}
