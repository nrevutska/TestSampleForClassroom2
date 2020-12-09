using Calculations;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalculatorTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [DataRow(1, 1, 4)]
        [DataRow(10, 100, 110)]
        [DataRow(3, 4, 7)]
        public void Add_MultipleNumbers_ReturnsSumOfNumbers(int param1, int param2, int expected)
        {
            int actual = Calculator.Add(param1, param2);

            Assert.AreEqual(expected, actual);
        }
    }
}
