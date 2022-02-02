using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _04_TagHelpers.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Add(int id)
        {
            return View();
        }
    }
}
