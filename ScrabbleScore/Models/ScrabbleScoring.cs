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

    private static char[] _scoreThree = {'B','C','M','P'};
    private static char[] _scoreFour = {'F','H','V','W','Y'};
    private static char[] _scoreFive = {'K'};
    private static char[] _scoreEight = {'J','X'};
    private static char[] _scoreTen = {'Z','Q'};

    private static Dictionary<char[],int> _wordScores = new Dictionary<char[],int>() { {_scoreOne,1}, {_scoreTwo,2}, {_scoreThree,3}, {_scoreFour,4}, {_scoreFive,5}, {_scoreEight,8}, {_scoreTen,10} };
    public ScrabbleScoring(string playedWord)
    {
      PlayedWord = playedWord;
    }
    public int GetScore()
    {
      string capsWord = PlayedWord.ToUpper();
      char[] wordArray = capsWord.ToCharArray();
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
        else if (_scoreThree.Contains(element))
        {
          wordScore = wordScore + _wordScores[_scoreThree];
        }
        else if (_scoreFour.Contains(element))
        {
          wordScore = wordScore + _wordScores[_scoreFour];
        }
        else if (_scoreFive.Contains(element))
        {
          wordScore = wordScore + _wordScores[_scoreFive];
        }
        else if (_scoreEight.Contains(element))
        {
          wordScore = wordScore + _wordScores[_scoreEight];
        }
        else if (_scoreTen.Contains(element))
        {
          wordScore = wordScore + _wordScores[_scoreTen];
        }
      }
      return wordScore;
    }
  }
}