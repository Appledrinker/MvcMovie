using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        //
        // GET: /HelloWorld/
        //public string Index()
        //{
        //    return "This is my default action ...";
        //}

        // GET: /HelloWorld/Welcome/
        public IActionResult Welcome(string name, int numTimes = 1)
        {
            //return HtmlEncoder.Default.Encode($"Hello {name}, ID: {ID}");

            ViewData["Message"] = "Hello " + name;
            ViewData["NumTimes"] = numTimes;

            return View();
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
