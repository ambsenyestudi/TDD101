using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestDrivenDevelopment101.Source;

namespace TDD_TestProject
{
    [TestClass]
    public class InputManagerUT
    {
        private InputReader _inputReader;
        [TestInitialize]
        public void InitializerTestContext()
        {
            _inputReader = new InputReader();
        }
        [TestMethod]
        public void WhenNumberNullShouldNotValidate()
        {
            string number = null;
            bool success = _inputReader.ValidateNumber(number);
            Assert.IsFalse(success);
        }
        [TestMethod]
        public void WhenNotNumberShouldNotValidate()
        {
            string number = "dummy input";
            bool success = _inputReader.ValidateNumber(number);
            Assert.IsFalse(success);
        }
        [TestMethod]
        public void WhenNegativeNumberShouldNotValidate()
        {
            string number = "-1";
            bool success = _inputReader.ValidateNumber(number);
            Assert.IsFalse(success);
        }
        [TestMethod]
        public void WhenPositiveNumberShouldValidate()
        {
            string number = "7";
            bool success = _inputReader.ValidateNumber(number);
            Assert.IsTrue(success);
        }
    }
}
