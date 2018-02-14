using SimpleCalculator.EnumApp;
using System;

namespace SimpleCalculator
{
    public class CalculatorEngine
    {
        public double Calculate(CalcOperations argOperation, double argFirstNumber, double argSecondNumber)
        {

            double resultOperation = 0;

            switch (argOperation)
            {
                case CalcOperations.Add:
                    resultOperation = argFirstNumber + argSecondNumber;
                    break;

                case CalcOperations.Subtract:
                    resultOperation = argFirstNumber - argSecondNumber;

                    break;

                case CalcOperations.Divide:
                    resultOperation = argFirstNumber / argSecondNumber;

                    break;

                case CalcOperations.Multiply:
                    resultOperation = argFirstNumber * argSecondNumber;

                    break;

                default:
                    throw new InvalidOperationException("Specified operation is note recognized");
                   
            }

            return resultOperation;
        }
    }
}