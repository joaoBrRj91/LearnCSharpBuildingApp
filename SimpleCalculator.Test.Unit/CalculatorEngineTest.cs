using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SimpleCalculator.Test.Unit
{

    /// <summary>
    /// Unit Test have 3 steps.
    /// 1: ARRANGE
    /// 2: ACT
    /// 3: ASSERT
    /// 
    /// So the arrange section you only have code required to setup that specific test.
    /// Here objects would be created, mocks setup (if you are using one) and potentially expectations would be set.
    /// Then there is the Act, which should be the invocation of the method being tested. 
    /// And on Assert you would simply check whether the expectations were met.
    /// </summary>
    [TestClass]
    public class CalculatorEngineTest
    {
        private readonly CalculatorEngine calculator = new CalculatorEngine();

        [TestMethod]
        public void AddsTwoNumbersAndReturnValidResultForNonSymbolOperation()
        {
            //ARRANGE
            int number1 = 1;
            int number2 = 2;

            //ACT
            double result = calculator.Calculate(EnumApp.CalcOperations.Add, number1, number2);

            //ASSERT
            Assert.AreEqual(expected: 3, actual: result);

        }


        //This method is for test when refactoring for use Symbol operation  and not word operation
        [TestMethod]
        public void AddsTwoNumbersAndReturnValidResultForSymbolOperation()
        {
           

        }
    }
}
