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
        Random rnd = new Random();

        [HttpGet]
        public IActionResult Index()
        {
            HttpContext.Session.SetInt32("number", rnd.Next(1, 100));
            return View();
        }

        [HttpPost]
        public IActionResult Index(int guess)
        {
            ViewBag.Msg = GuessingGame.checkGuess((int)HttpContext.Session.GetInt32("number"), guess);
            if (guess == (int)HttpContext.Session.GetInt32("number"))
            {
                HttpContext.Session.SetInt32("number", rnd.Next(1, 100));
            }
            return View();
        }
    }
}
