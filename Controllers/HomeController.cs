using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.InteropServices;

namespace AspNetCoreExample.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index() => View();

        public IActionResult About()
        {
            ViewBag.OSName = RuntimeInformation.OSDescription;
            return View();
        }

        public IActionResult Contact() => View();

        public IActionResult Error() => View();

        public IActionResult Protected() => View();
    }
}
