using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Wardrobe.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetOutfit()
        {
            WardRobeController wardrobe = new WardRobeController();
            var item = wardrobe.Get(1);
            if (item.Picture == null)
            {
                item.Picture = new Uri("http://en.wikipedia.org/wiki/File:Texas_Tech_Red_Raiders_baseball_cap.jpg");
            }
            return View("ItemView", item);
        }
    }
}
