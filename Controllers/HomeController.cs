using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVC_ComicBooksCharacters.Models;

namespace MVC_ComicBooksCharacters.Controllers
{
    public class HomeController : Controller
    {
        private ComicBookContext _ctx = null;
        public HomeController(ComicBookContext ctx)
        {
            _ctx = ctx;
        }
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View(_ctx);
        }
    }
}
