using System.Collections.Generic;
using System;
using System.Linq;

namespace ScrabbleScore.Models
{
    public class ScrabbleScoring
    {
        public string Word { get; set; }

        public ScrabbleScoring(string word)
        {
            Word = word;
        }

        public int GetScore()
        {
            string userEnteredWord = Word.ToUpper();
            var letterValue = new Dictionary<string, int>() {  {"A", 1},{"E", 1},{"I", 1},{"O", 1},{"U", 1},{"L", 1},{"N", 1},{"R", 1},{"S", 1},{"T", 1},{"D", 2},{"G", 2},
            {"B", 2},{"C", 2},{"M", 2},{"P", 2}, {"F", 3},{"H", 3},{"V", 3},{"W", 3}, {"Y", 3}, {"K", 5}, {"J", 8},{"X", 8}, {"Q", 10},{"Z", 10} };
            int score = 0;
            foreach (char letter in userEnteredWord)
            {
                score = score + letterValue[letter.ToString()];  //Char.ToString
            }
            return score;
        }
    }
}