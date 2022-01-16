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

using System.Drawing;
using System.Drawing.Imaging;
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
            Image image1 = Image.FromFile(filter1.Photo);

            //create a blank bitmap the same size as original
            Bitmap newBitmap = new Bitmap(image1);

            //get a graphics object from the new image
            Graphics g = Graphics.FromImage(newBitmap);

            //create the grayscale ColorMatrix
            ColorMatrix colorMatrix = new ColorMatrix(
               new float[][]
               {
                new float[] {.3f, .3f, .3f, 0, 0},
                new float[] {.59f, .59f, .59f, 0, 0},
                new float[] {.11f, .11f, .11f, 0, 0},
                new float[] {0, 0, 0, 1, 0},
                new float[] {0, 0, 0, 0, 1}
               });

            //create some image attributes
            ImageAttributes attributes = new ImageAttributes();

            //set the color matrix attribute
            attributes.SetColorMatrix(colorMatrix);

            //draw the original image on the new image
            //using the grayscale color matrix
            g.DrawImage(newBitmap, new Rectangle(0, 0, newBitmap.Width, newBitmap.Height),
               0, 0, newBitmap.Width, newBitmap.Height, GraphicsUnit.Pixel, attributes);

            //dispose the Graphics object
            //g.Dispose();
              static byte[] BitmapToBytes(Image img)
            {
                using (MemoryStream stream = new MemoryStream())
                {
                    img.Save(stream, System.Drawing.Imaging.ImageFormat.Png);
                    return stream.ToArray();
                }
            }

            filter1.Bitmapa = BitmapToBytes(newBitmap);
            ViewBag.Bitmapa = filter1.Bitmapa;
            return View("filter1w");
        }
        [HttpGet]
        public IActionResult Filter2()
        {


            return View();

        }
        [HttpPost]
        public IActionResult Filter2(Filter2 filter2)
        {

            using (StreamWriter sw = new StreamWriter(@"Save.txt"))
            {

                sw.WriteLine(filter2.Photo);

            }
            ViewBag.Photo = filter2.Photo;
            Image image2 = Image.FromFile(filter2.Photo);

            //create a blank bitmap the same size as original
            Bitmap newBitmap = new Bitmap(image2);

            //get a graphics object from the new image
            Graphics g = Graphics.FromImage(newBitmap);

            //create the grayscale ColorMatrix
            ColorMatrix colorMatrix = new ColorMatrix(
               new float[][]
               {
                new float[] {.3f, .3f, .3f, 0, 0},
                new float[] {.59f, .59f, .59f, 0, 0},
                new float[] {.11f, .11f, .11f, 0, 0},
                new float[] {0, 0, 0, 1, 0},
                new float[] {0, 0, 0, 0, 1}
               });

            //create some image attributes
            ImageAttributes attributes = new ImageAttributes();

            //set the color matrix attribute
            attributes.SetColorMatrix(colorMatrix);

            //draw the original image on the new image
            //using the grayscale color matrix
            g.DrawImage(newBitmap, new Rectangle(0, 0, newBitmap.Width, newBitmap.Height),
               0, 0, newBitmap.Width, newBitmap.Height, GraphicsUnit.Pixel, attributes);

            //dispose the Graphics object
            //g.Dispose();
            static byte[] BitmapToBytes(Image img)
            {
                using (MemoryStream stream = new MemoryStream())
                {
                    img.Save(stream, System.Drawing.Imaging.ImageFormat.Png);
                    return stream.ToArray();
                }
            }

            filter2.Bitmapa = BitmapToBytes(newBitmap);
            ViewBag.Bitmapa = filter2.Bitmapa;
            return View("filter2w");
        }
        [HttpGet]
        public IActionResult Filter3()
        {


            return View();

        }
        [HttpPost]
        public IActionResult Filter3(Filter3 filter3)
        {
            using (StreamWriter sw = new StreamWriter(@"Save.txt"))
            {

                sw.WriteLine(filter3.Photo);

            }
            ViewBag.Photo = filter3.Photo;
            Image image3 = Image.FromFile(filter3.Photo);

            //create a blank bitmap the same size as original
            Bitmap newBitmap = new Bitmap(image3);

            //get a graphics object from the new image
            Graphics g = Graphics.FromImage(newBitmap);

            //create the grayscale ColorMatrix
            ColorMatrix colorMatrix = new ColorMatrix(
               new float[][]
               {
                new float[] {.3f, .3f, .3f, 0, 0},
                new float[] {.59f, .59f, .59f, 0, 0},
                new float[] {.11f, .11f, .11f, 0, 0},
                new float[] {0, 0, 0, 1, 0},
                new float[] {0, 0, 0, 0, 1}
               });

            //create some image attributes
            ImageAttributes attributes = new ImageAttributes();

            //set the color matrix attribute
            attributes.SetColorMatrix(colorMatrix);

            //draw the original image on the new image
            //using the grayscale color matrix
            g.DrawImage(newBitmap, new Rectangle(0, 0, newBitmap.Width, newBitmap.Height),
               0, 0, newBitmap.Width, newBitmap.Height, GraphicsUnit.Pixel, attributes);

            //dispose the Graphics object
            //g.Dispose();
            static byte[] BitmapToBytes(Image img)
            {
                using (MemoryStream stream = new MemoryStream())
                {
                    img.Save(stream, System.Drawing.Imaging.ImageFormat.Png);
                    return stream.ToArray();
                }
            }

            filter3.Bitmapa = BitmapToBytes(newBitmap);
            ViewBag.Bitmapa = filter3.Bitmapa;
            return View("filter3w");
        }

      

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

    }
}
