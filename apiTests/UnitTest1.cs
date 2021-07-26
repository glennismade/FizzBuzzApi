// using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using api;

namespace apiTests
{
    [TestFixture]
    public class UnitTest1
    {
        [TestCase(1, "1")]
        [TestCase(2, "2")]
        [TestCase(3, "Fizz")]
        [TestCase(5, "Buzz")]
        [TestCase(6, "Fizz")]
        [TestCase(10, "Buzz")]
        [TestCase(15, "FizzBuzz")]
        [TestCase(30, "FizzBuzz")]

        public void givenFizzBuzzMethodPassedIntIfMatchesThenReturnsString(int input, string expected)
        {
            FizzBuzz fizzBuzz = new FizzBuzz();

            string result = fizzBuzz.FizzBuzzer(input, 3, 5);

            Assert.AreEqual(expected, result);
        }
    }
}
