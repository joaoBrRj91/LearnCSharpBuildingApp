
using System;
using System.Collections.Generic;
using WorldUnscrambler.Data;
using WorldUnscrambler.Helpers;

namespace WorldUnscrambler.Workers
{
    //TODO: Refactoring this class because her violeted multiples principes of the OOP. For exemple DRY('DONT REPEAT YOURSELF')
    public class WordMacther
    {
        public List<MatchedWord> Match(string[] scrambledWords, string[] wordList)
        {

            var matchedWords = new List<MatchedWord>();

            foreach (var scrambledWord in scrambledWords)
            {

                foreach (var word in wordList)
                {

                    if (scrambledWord.Equals(word, StringComparison.OrdinalIgnoreCase))
                    {
                        matchedWords.Add(WordMactherHelper.BuildMatchedWord(scrambledWord, word));
                    }
                    else
                    {

                        var scrambledWordArray = scrambledWord.ToCharArray();
                        var wordArray = word.ToCharArray();

                        Array.Sort(scrambledWordArray);
                        Array.Sort(wordArray);

                        var sortedScrambledWord = new string(scrambledWordArray);
                        var sortedWord = new string(wordArray);

                        if (sortedScrambledWord.Equals(sortedWord, StringComparison.OrdinalIgnoreCase))
                        {
                            matchedWords.Add(WordMactherHelper.BuildMatchedWord(scrambledWord, word));
                        }



                    }


                }
            }

            return matchedWords;
        }
    }
}
