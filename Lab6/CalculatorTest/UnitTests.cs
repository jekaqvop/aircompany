using NUnit.Framework;
using Lab6;
using System;

namespace CalculatorTest
{
    public class Tests
    {        
        [Test]
        [TestCase(1, 2, 3)]
        [TestCase(2, 2, 4)]
        [TestCase(3, 2, 5)]
        [TestCase(1, 5, 6)]
        public void PlusTwoPositiveNumbers(int value1, int value2, int expectedValue)
        {
            int result = Calculator.Sum(value1, value2);
            Assert.AreEqual(expectedValue, result);
        }

        [Test]
        [TestCase(-1, -2, -3)]
        [TestCase(-2, -2, -4)]
        [TestCase(-3, -2, -5)]
        [TestCase(-1, -5, -6)]
        public void PlusTwoNegativeNumbers(int value1, int value2, int expectedValue)
        {
            int result = Calculator.Sum(value1, value2);
            Assert.AreEqual(expectedValue, result);
        }

        [Test]
        [TestCase(1, 2, -1)]
        [TestCase(2, 2, 0)]
        [TestCase(3, 2, 1)]
        [TestCase(1, 5, -4)]
        public void SubstractTwoPositiveNumbers(int value1, int value2, int expectedValue)
        {
            int result = Calculator.Substract(value1, value2);
            Assert.AreEqual(expectedValue, result);
        }

        [Test]
        [TestCase(-1, -2, 1)]
        [TestCase(-2, -2, 0)]
        [TestCase(-3, -2, -1)]
        [TestCase(-1, -5, 4)]
        public void SubstractTwoNegativeNumbers(int value1, int value2, int expectedValue)
        {
            int result = Calculator.Substract(value1, value2);
            Assert.AreEqual(expectedValue, result);
        }

        [Test]
        [TestCase(1, 2, 2)]
        [TestCase(2, 2, 4)]
        [TestCase(3, 2, 6)]
        [TestCase(4, 2, 8)]
        public void MultiplyTwoPositiveNumbers(int value1, int value2, int expectedValue)
        {
            int result = Calculator.Multiply(value1, value2);
            Assert.AreEqual(expectedValue, result);
        }

        [Test]
        [TestCase(-1, -2, 2)]
        [TestCase(-2, -2, 4)]
        [TestCase(-3, -2, 6)]
        [TestCase(-1, -5, 5)]
        public void MultiplyTwoNegativeNumbers(int value1, int value2, int expectedValue)
        {
            int result = Calculator.Multiply(value1, value2);
            Assert.AreEqual(expectedValue, result);
        }

        [Test]
        [TestCase(1, 2, 0)]
        [TestCase(2, 2, 1)]
        [TestCase(3, 2, 1)]
        [TestCase(4, 2, 2)]
        public void DivideTwoPositiveNumbers(int value1, int value2, int expectedValue)
        {
            int result = Calculator.Divide(value1, value2);
            Assert.AreEqual(expectedValue, result);
        }

        [Test]
        [TestCase(-1, -2, 0)]
        [TestCase(-2, -2, 1)]
        [TestCase(-3, -2, 1)]
        [TestCase(-1, -5, 0)]
        public void DivideTwoNegativeNumbers(int value1, int value2, int expectedValue)
        {
            int result = Calculator.Divide(value1, value2);
            Assert.AreEqual(expectedValue, result);
        }

        [Test]
        [TestCase(1, 2, 1)]
        [TestCase(2, 2, 0)]
        [TestCase(3, 2, 1)]
        [TestCase(4, 2, 0)]
        public void DivideByModelTwoPositiveNumbers(int value1, int value2, int expectedValue)
        {
            int result = Calculator.DivideByModel(value1, value2);
            Assert.AreEqual(expectedValue, result);
        }

        [Test]
        [TestCase(-1, -2, -1)]
        [TestCase(-2, -2, 0)]
        [TestCase(-3, -2, -1)]
        [TestCase(-1, -5, -1)]
        public void DivideByModelTwoNegativeNumbers(int value1, int value2, int expectedValue)
        {
            int result = Calculator.DivideByModel(value1, value2);
            Assert.AreEqual(expectedValue, result);
        }

        [Test]
        [TestCase(-1, 0)]
        public void Divide_InvalidDividerEqualToZero_ThrowsDivideByZeroException(int value1, int value2)
        {         
            Assert.Throws<ArgumentException>(() => Calculator.Divide(value1, value2));
        }

        [Test]
        [TestCase(-1, 0)]
        public void DivideByModelInvalidDividerEqualToZero_ThrowsDivideByZeroException(int value1, int value2)
        {
            Assert.Throws<ArgumentException>(() => Calculator.DivideByModel(value1, value2));
        }
    }
}