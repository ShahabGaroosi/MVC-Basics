using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MVC_Basics.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_Basics.Controllers
{
    public class GuessingGameController : Controller
    {
        public IActionResult Index()
        {
            Random rnd = new Random();
            HttpContext.Session.SetInt32("number", rnd.Next(1, 100));
            return View();
        }
        public IActionResult Index2(int guess)
        {
            ViewBag.Msg = GuessingGame.checkGuess((int)HttpContext.Session.GetInt32("number"), guess);
            return View();
        }
    }
}
