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
            
            return PartialView("OutfitView", outfit);
        }
    }
}
