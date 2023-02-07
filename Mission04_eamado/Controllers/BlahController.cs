using Microsoft.AspNetCore.Mvc;
using Mission04_eamado.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission04_eamado.Controllers
{
    public class BlahController : Controller //inheritence ':'
    {
        public IActionResult Index()
        {
            return View(); //returning a view associated with the index view if nothing is inside view() parameters
        }
        [HttpGet]
        public IActionResult FanMail ()
        {
            return View();
        }
        [HttpPost]
        public IActionResult FanMail (FanMailModel model)
        {
            return View();
        }
    }
}
