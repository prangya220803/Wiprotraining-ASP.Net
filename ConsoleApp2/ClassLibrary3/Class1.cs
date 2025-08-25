using NUnit.Framework;
using Calculator;
using System;

namespace Calculator.Test
{
    [TestFixture]
    public class Class1
    {
        [Test]
        public void ShouldAddTwoNumbers()
        {
            var calc = new Calculator();
            var result = calc.Add(5.5, 4.5);
            Assert.AreEqual(10.0, result);
        }

        [Test]
        public void ShouldSubtractTwoNumbers()
        {
            var calc = new Calculator();
            var result = calc.Subtract(10.0, 3.0);
            Assert.AreEqual(7.0, result);
        }

        [Test]
        public void ShouldMultiplyTwoNumbers()
        {
            var calc = new Calculator();
            var result = calc.Multiply(3.0, 4.0);
            Assert.AreEqual(12.0, result);
        }

        [Test]
        public void ShouldDivideTwoNumbers()
        {
            var calc = new Calculator();
            var result = calc.Divide(20.0, 4.0);
            Assert.AreEqual(5.0, result);
        }

        [Test]
        public void ShouldThrowExceptionWhenDividingByZero()
        {
            var calc = new Calculator();
            Assert.Throws<DivideByZeroException>(() => calc.Divide(10.0, 0));
        }

        [Test]
        public void ShouldAddWithZero()
        {
            var calc = new Calculator();
            var result = calc.Add(0.0, 10.0);
            Assert.AreEqual(10.0, result);
        }

        [Test]
        public void ShouldSubtractWithZero()
        {
            var calc = new Calculator();
            var result = calc.Subtract(10.0, 0.0);
            Assert.AreEqual(10.0, result);
        }
    }
}
