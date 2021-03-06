using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using EpicodusGames.Controllers;
using EpicodusGames.Models;

namespace EpicodusGames.Controllers
{
  public class Game3Controller : Controller
  {
    [HttpGet("/game3")]
    public ActionResult Index()
    {
      Account activeAccount = Account.FindActiveAccount();
      return View(activeAccount);
    }

    [HttpGet("/play3")]
    public ActionResult Play()
    {
      Account activeAccount = Account.FindActiveAccount();
      activeAccount.AddXp();
      activeAccount.UpdateXp(activeAccount.Id);
      activeAccount.UpdateCurrentLevelXp(activeAccount.Id);
      activeAccount.UpdateLevelBar(activeAccount.Id);
      return View(activeAccount);
    }


  }
}
