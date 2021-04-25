using Microsoft.AspNetCore.Mvc;
using ScrabbleScore.Models;

namespace FriendLetter.Controllers
{
  public class HomeController : Controller
  {
    [Route("/")]
    public ActionResult ScrabbleWord() { return View(); }

    [Route("/wordscore")]
    public ActionResult WordScore(string word) 
    {
      ScrabbleScoring objScrabbleScoring = new ScrabbleScoring(word);
      return View(objScrabbleScoring); 
    }
  }
}