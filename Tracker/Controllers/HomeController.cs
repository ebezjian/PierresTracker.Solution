using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System;
using Tracker.Models;
namespace Tracker.Controllers
{
  public class HomeController : Controller
  {

    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }
  }
}