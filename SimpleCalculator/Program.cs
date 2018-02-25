using SimpleCalculator.EnumApp;
using System;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            InputConverter    Converter = new InputConverter();
            CalculatorEngine Calculator = new CalculatorEngine();


            try
            {
                double firstNumber = Converter.ConvertInputToNumeric(Console.ReadLine());
                double secondNumber = Converter.ConvertInputToNumeric(Console.ReadLine());
                string operation = Console.ReadLine();

                //TODO: Refactoring Method converting string for enum because if the string is invalid enumApp the app throw error parse
                double result = Calculator.Calculate((CalcOperations)Enum.Parse(typeof(CalcOperations), operation), firstNumber, secondNumber);

                Console.WriteLine(result);

            }
            catch (ArgumentException ex)
            {
                //TDOO: START LOGGING EXCEPTIONS
                Console.WriteLine(ex.Message);
            }
            catch (InvalidOperationException ex)
            {
                //TDOO: START LOGGING EXCEPTIONS
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                //TDOO: START LOGGING EXCEPTIONS
                Console.WriteLine(ex.Message);
            }
        }


        //private static void TextManipulation()
        //{

        //    /*This is not clean because I used literals values */
        //    string someText = "Here is some text";
        //    string someOtherText = "here is some text";

        //    // This is inicialize clean variable
        //    string someVariableClean = string.Empty;

        //    //Character by Charater comparison: Is fast method comparison two strings
        //    bool isEqual = someText.Equals(someOtherText, System.StringComparison.Ordinal);

        //    // return "some"
        //    string getSubString = someText.Substring(8, 4);

        //    string replacedText = someText.Replace("text", "word";)

        //}

    }
}
