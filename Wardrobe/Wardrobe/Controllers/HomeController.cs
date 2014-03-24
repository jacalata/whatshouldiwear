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
            Wardrobe.Models.Outfit outfit = new Wardrobe.Models.Outfit();
            outfit.Top = wardrobe.Get(Wardrobe.Models.ClothingType.Top);
            outfit.Bottom = wardrobe.Get(Wardrobe.Models.ClothingType.Bottom);
            outfit.Hat = wardrobe.Get(Wardrobe.Models.ClothingType.Hat);
            outfit.Shoes = wardrobe.Get(Wardrobe.Models.ClothingType.Shoes);
            outfit.Coat = wardrobe.Get(Wardrobe.Models.ClothingType.Coat);
            


            var item = wardrobe.Get(1);
            if (item.Picture == null)
            {
                item.Picture = new Uri("http://upload.wikimedia.org/wikipedia/commons/2/23/Texas_Tech_Red_Raiders_baseball_cap.jpg");
            }
            return PartialView("OutfitView", outfit);
        }
    }
}
