using Microsoft.AspNetCore.Mvc;
using MVC_Basics.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_Basics.Controllers
{
    public class DoctorController : Controller
    {
        public IActionResult Index(double temperature)
        {
            ViewBag.Msg = Doctor.feverCheck(temperature);
            return View();
        }
    }
}
