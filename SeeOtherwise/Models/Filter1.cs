using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Helpers;
namespace SeeOtherwise.Models
{
    public class Filter1
    {
        public string Photo { get; set; }
        public Filter1(string photo)
        {
            
            Photo = photo;

        }
    }

}
