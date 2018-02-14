using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SimpleCalculator.Test.Unit
{
    [TestClass]
    public class InputConverterTest
    {
        private readonly InputConverter inputConverter = new InputConverter();

        [TestMethod]
        public void ConvertsValidStringInputIntoDouble()
        {

            string inputNumber = "5";
            double convertedNumber = inputConverter.ConvertInputToNumeric(inputNumber);
            Assert.AreEqual(expected: 5, actual: convertedNumber);
        }



        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void FailsToConvertInvalidStringInputIntoDouble()
        {

            string inputNumber = "*";
            double convertedNumber = inputConverter.ConvertInputToNumeric(inputNumber);
           
        }

    }
}
