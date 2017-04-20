using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestDrivenDevelopment101.Source;

namespace TDD_TestProject
{
    [TestClass]
    public class WordToNumberRecognizerUT
    {
        private WordToNumberRecognizer _wordToNumberRecognizer;

        [TestInitialize]
        public void InitializeTestContext()
        {
            _wordToNumberRecognizer = new WordToNumberRecognizer();
        }

        [TestMethod]
        public void WhenNullShouldNotReconize()
        {
            bool isNumber = _wordToNumberRecognizer.Recognize(null);
            Assert.IsFalse(isNumber);
        }
        [TestMethod]
        public void WhenUnitNumberShouldReconize()
        {
            string unitNumber = NumberRepository.Units[7];
            bool isNumber = _wordToNumberRecognizer.Recognize(unitNumber);
            Assert.IsTrue(isNumber);
        }
        [TestMethod]
        public void WhenTenUnitNumberShouldReconize()
        {
            string tenUnitNumber = NumberRepository.TenUnits[7];
            bool isNumber = _wordToNumberRecognizer.Recognize(tenUnitNumber);
            Assert.IsTrue(isNumber);
        }
        [TestMethod]
        public void WhenTensNumberShouldReconize()
        {
            string tensNumber = NumberRepository.Tens[3];
            bool isNumber = _wordToNumberRecognizer.Recognize(tensNumber);
            Assert.IsTrue(isNumber);
        }
        [TestMethod]
        public void WhenTensAndUnitNumberShouldReconize()
        {
            //Twenty four
            string tensAndNumber = string.Format("{0} {1}",
                NumberRepository.Tens[2],
                NumberRepository.Units[4]);
            bool isNumber = _wordToNumberRecognizer.Recognize(tensAndNumber);
            Assert.IsTrue(isNumber);
        }
        [TestMethod]
        public void WhenTensAndJibrishNumberShouldNotReconize()
        {
            //Twenty BlaBla
            string tensAndNumber = string.Format("{0} {1}",
                NumberRepository.Tens[2],
                "BlaBla");
            bool isNumber = _wordToNumberRecognizer.Recognize(tensAndNumber);
            Assert.IsFalse(isNumber);
        }
        [TestMethod]
        public void WhenWierdCombinationNumberShouldNotReconize()
        {
            //Ten Six
            string tensAndNumber = string.Format("{0} {1}",
                NumberRepository.Tens[1],
                NumberRepository.Units[6]);
            bool isNumber = _wordToNumberRecognizer.Recognize(tensAndNumber);
            Assert.IsFalse(isNumber);
        }
        [TestMethod]
        public void WhenLessThanHundredShouldReconize()
        {
            //Ninety Nine
            string tensAndNumber = string.Format("{0} {1}",

                NumberRepository.Tens[9],
                NumberRepository.Units[9]);
            bool isNumber = _wordToNumberRecognizer.Recognize(tensAndNumber);
            Assert.IsTrue(isNumber);
        }
        //This more than a hundred is next fase
        [TestMethod]
        public void WhenNotLessThanHundredShouldNotReconize()
        {
            //One Hundred Ninety Nine
            string tensAndNumber = string.Format("{0} {1} {2} {3}",
                "One",
                "Hundred",
                NumberRepository.Tens[9],
                NumberRepository.Units[9]);
            bool isNumber = _wordToNumberRecognizer.Recognize(tensAndNumber);
            Assert.IsFalse(isNumber);
        }
        //TODO Fix this
        [TestMethod]
        public void WhenDiferentCasingNumberShouldReconize()
        {
            //NINETY nine
            string tensAndNumber = string.Format("{0} {1}",

                NumberRepository.Tens[9].ToUpper(),
                NumberRepository.Units[9].ToLower());
            bool isNumber = _wordToNumberRecognizer.Recognize(tensAndNumber);
            Assert.IsTrue(isNumber);
        }
    }
}
