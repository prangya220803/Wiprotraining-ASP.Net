using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Calculator.Test
{
    [TestClass]
    public class Class1
    {
        [TestMethod]
        public void shouldaddTwoNumbers()
        {
            var c = new Calculator();
            var result = c.Add(2, 13);
            Assert.AreEqual(15, result);
        }
        [TestMethod]
        public void shouldmultiplyTwoNumbers()
        {
            var c = new Calculator();
            var result = c.Multiply(2, 20);
            Assert.AreEqual(40, result);
        }
    }
}