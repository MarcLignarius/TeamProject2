
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using EpicodusGames.Controllers;
using EpicodusGames.Models;

namespace EpicodusGames.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }

    [HttpGet("/show")]
    public ActionResult Show()
    {
    return View();
    }

    [HttpGet("/games")]
    public ActionResult Games()
    {
      Account activeAccount = Account.FindActiveAccount();
      return View(activeAccount);
    }

    [HttpGet("/contact")]
    public ActionResult Contact()
    {
        return View();
    }

    [HttpGet("/about")]
    public ActionResult About()
    {
        return View();
    }
  }
}
