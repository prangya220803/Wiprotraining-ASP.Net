//using NUnit.Framework;
using ConsoleApp2;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace ClassLibrary1
{
    [TestClass]
    public class CalculatorTest
    {
        [TestMethod]
        public void shouldaddTwoNumbers()
        {
            var c = new Calculator();
            var result = c.Add(2, 13);
            Assert.That(result, Is.EqualTo(15));
        }
        [TestMethod]
        public void shouldmultiplyTwoNumbers()
        {
            var c = new Calculator();
            var result = c.Multiply(2, 20);
            Assert.That(result, Is.EqualTo(40));
        }
    }
}