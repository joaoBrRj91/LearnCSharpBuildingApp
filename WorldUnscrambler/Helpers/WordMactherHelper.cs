using WorldUnscrambler.Data;

namespace WorldUnscrambler.Helpers
{
    public static class WordMactherHelper
    {

        public static MatchedWord BuildMatchedWord(string scrambledWord, string word) 
                     => new MatchedWord { ScrambledWord = scrambledWord, Word = word };
        
    }
}
