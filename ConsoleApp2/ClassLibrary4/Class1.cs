using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace CalculatorTest
{
    [TestClass]
    public class Class1
    {
        [Test]
        public void shouldaddTwoNumbers()
        {
            var c = new Calculator();
            var result = c.Add(2, 13);
            Assert.That(result, Is.EqualTo(15));
        }
        [Test]
        public void shouldmultiplyTwoNumbers()
        {
            var c = new Calculator();
            var result = c.Multiply(2, 20);
            Assert.That(result, Is.EqualTo(40));
        }
    }
}