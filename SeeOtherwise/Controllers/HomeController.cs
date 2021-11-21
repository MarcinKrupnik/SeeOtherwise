using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SeeOtherwise.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Helpers;
namespace SeeOtherwise.Controllers
{
    public class HomeController : Controller
    {
        
        Filter1 filter1;
        public HomeController()
        {
           
           
            this.filter1 = new Filter1("~/Photo.jpg");
            new Filter1("~/Photo.jpg");
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Filter1()
        {
            Filter1 filter1= this.filter1;
            return View(filter1);
        }
        public IActionResult Filter2()
        {
            return View();
        }
        public IActionResult Filter3()
        {
            return View();
        }
     

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
