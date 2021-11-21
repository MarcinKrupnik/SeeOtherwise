using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Imaging;

namespace SeeOtherwise.Models
{
    public class Filter1
    {
        public static Bitmap Zin(Bitmap original)
        {
            //create a blank bitmap the same size as original
            Bitmap newBitmap = new Bitmap(original.Width, original.Height);

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
            g.DrawImage(original, new Rectangle(0, 0, original.Width, original.Height),
               0, 0, original.Width, original.Height, GraphicsUnit.Pixel, attributes);

            //dispose the Graphics object
            g.Dispose();
            return newBitmap;
        }
        
        public Bitmap EdgeDetection()
	    {
	     Bitmap result;
      // var newBitmap = ToGrayScale();
	     lock (_imageLock)
	     {
	         result = new Bitmap(newBitmap);
	         var data = result.LockBits(new Rectangle(0, 0, newBitmap.Width, newBitmap.Height),
	                    ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
	 
	         var p = (byte*) data.Scan0.ToPointer();
	         var offset = data.Stride - result.Width * 3;
	 
	         for (var i = 0; i < result.Height - 1; i++)
	         {
	              for (var j = 0; j < result.Width - 1; j++)
	              {
	                   var Gx = (int) Math.Pow(p[0] - (p + 3 + data.Stride)[0], 2);
	                   var Gy = (int)Math.Pow((p + 3)[0] - (p + data.Stride)[0], 2);
	 
	                    var f = Gx + Gy;
	                    p[0] = p[1] = p[2] = (byte) f;
	 
	                    p += 3;
	               }
	 
	               p += offset;
	         }
	 
	         result.UnlockBits(data);
	     }
	 
	     return result;
	}
    }
    
    
    
}


// szkielet algorytmu, jak bedzie juz wrzucanie zdjec to bede pracowal nad ColorMatrix zeby wygladalo jakotako
