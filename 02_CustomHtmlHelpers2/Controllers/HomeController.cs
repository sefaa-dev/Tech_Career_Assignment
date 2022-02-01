using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _02_CustomHtmlHelpers2.Extensions;

namespace _02_CustomHtmlHelpers2.Controllers
{
    public class HomeController : Controller
    {
        public string GetText()
        {
            string text = "çalışkan";
            return text.ClearTurkishCharacters();
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
