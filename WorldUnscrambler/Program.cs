using System;
using System.Collections.Generic;
using System.Linq;
using WorldUnscrambler.Data;
using WorldUnscrambler.Workers;

namespace WorldUnscrambler
{

    //TODO : Refactoring this code because this is not clean.
    class Program
    {

        private static readonly FileReader fileReader = new FileReader();
        private static readonly WordMacther wordMatcher = new WordMacther();
        private const string worldListFileName = "wordlist.txt";

        static void Main(string[] args)
        {
            bool continueWordUnscramble = true;

            do
            {

                  
                Console.WriteLine("Please enter the option - F for file and M for Manual.");
                var option = (Console.ReadLine() ?? string.Empty);

                switch (option.ToUpper())
                {
                    case "F":
                        Console.Write("Enter scrambled words file name: ");
                        ExecuteScrambleWordsInFileScenario();
                        break;

                    case "M":
                        Console.Write("Enter scrambled words manually: ");
                        ExecuteScrambleWordsInManualEntryScenario();
                        break;

                    default:
                        Console.WriteLine("Option was not recognized");
                        break;
                }


                var continueWordUnscrambleDecision = string.Empty;

                do
                {

                    Console.WriteLine("Do you want to continue? Y/N");
                    continueWordUnscrambleDecision = (Console.ReadLine() ?? string.Empty);


                } while (
                           !continueWordUnscrambleDecision.Equals("Y",StringComparison.OrdinalIgnoreCase) &&
                           !continueWordUnscrambleDecision.Equals("N",StringComparison.OrdinalIgnoreCase));


                continueWordUnscramble = (continueWordUnscrambleDecision.Equals("Y", StringComparison.OrdinalIgnoreCase));


            } while (continueWordUnscramble);

        }


        private static void ExecuteScrambleWordsInManualEntryScenario()
        {

            var manualInput = (Console.ReadLine() ?? string.Empty);
            string[] scrambledWords = manualInput.Split(',');
            DisplayMatchedUnscrambledWords(scrambledWords);

        }

      
        private static void ExecuteScrambleWordsInFileScenario()
        {
            var fileName = (Console.ReadLine() ?? string.Empty);
            string[] scrambledWords = fileReader.Read(fileName);
            DisplayMatchedUnscrambledWords(scrambledWords);
        }


        private static void DisplayMatchedUnscrambledWords(string[] scrambledWords)
        {

            string[] wordList = fileReader.Read(worldListFileName);

            List<MatchedWord> matchedWords = wordMatcher.Match(scrambledWords, wordList);

            if (matchedWords.Any())
            {

                foreach (var matchedWord in matchedWords)
                {
                    Console.WriteLine("Match found for {0}: {1}", matchedWord.ScrambledWord, matchedWord.Word);
                }
            }
            else
            {
                Console.WriteLine("No matches have been found.");
            }
        }


    }
}
