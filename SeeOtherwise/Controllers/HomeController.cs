using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SeeOtherwise.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Helpers;
using System.Data.Entity;
using System.Drawing;

namespace SeeOtherwise.Controllers
{
    public class HomeController : Controller
    {
        
        
        public HomeController()
        {

            
       
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
    
        [HttpGet]
        public IActionResult Filter1()
        {


            return View();

        }

        [HttpPost]
        public IActionResult Filter1(Filter1 filter1)
        {
            

            using (StreamWriter sw = new StreamWriter(@"Save.txt"))
            {

                sw.WriteLine(filter1.Photo);

            }
            ViewBag.Photo = filter1.Photo;
            return View("filter1w");
            //Bitmap image1 = new Bitmap(filter1.Photo);

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
