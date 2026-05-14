using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PersonalityImageTestApp.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Result(string choice)
        {
            string personality;

            switch (choice)
            {
                case "nature":
                    personality = "Calm and Peaceful Personality";
                    break;

                case "city":
                    personality = "Ambitious and Energetic Personality";
                    break;

                case "space":
                    personality = "Creative and Curious Personality";
                    break;

                default:
                    personality = "Unknown Personality";
                    break;
            }

            ViewBag.Result = personality;
            return View();
        }
    }
}