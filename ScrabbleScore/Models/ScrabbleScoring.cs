using System.Collections.Generic;
using System;
using System.Linq;

namespace ScrabbleScore.Models
{
  public class ScrabbleScoring
  {
    public string PlayedWord { get; set; }
    private static char[] _scoreOne = {'A','E','I','O','U','L','N','R','S','T'};

    private static char[] _scoreTwo = {'D','G'};
    private static Dictionary<char[],int> _wordScores = new Dictionary<char[],int>() { {_scoreOne,1}, {_scoreTwo,2} };
    public ScrabbleScoring(string playedWord)
    {
      PlayedWord = playedWord;
    }
    public int GetScore()
    {
      char[] wordArray = PlayedWord.ToCharArray();
      int wordScore = 0;
      foreach(char element in wordArray)
      {
        if (_scoreOne.Contains(element))
        {
          wordScore = wordScore + _wordScores[_scoreOne];
        }
        else if (_scoreTwo.Contains(element))
        {
          wordScore = wordScore + _wordScores[_scoreTwo];
        }
      }
      return wordScore;
    }
  }
}