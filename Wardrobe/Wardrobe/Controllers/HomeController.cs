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
            outfit.Top.Picture = new Uri("http://www.downloadclipart.net/large/12218-blue-shirt-design.png");
            outfit.Bottom = wardrobe.Get(Wardrobe.Models.ClothingType.Bottom);
            outfit.Bottom.Picture = new Uri("http://doodleslide.com/clipart/jeans.jpg");
            outfit.Hat = wardrobe.Get(Wardrobe.Models.ClothingType.Hat);
            outfit.Hat.Picture = new Uri("http://upload.wikimedia.org/wikipedia/commons/2/23/Texas_Tech_Red_Raiders_baseball_cap.jpg");
           
            outfit.Shoes = wardrobe.Get(Wardrobe.Models.ClothingType.Shoes);
            outfit.Shoes.Picture = new Uri("http://images.mytheresa.com/media/catalog/product/cache/common/image/1000x1000/b9336446c29edafc3474017303b51028/P/0/P00059051-GUM-NEON-HIGH-TOP-SNEAKERS-STANDARD.jpg");
            outfit.Coat = wardrobe.Get(Wardrobe.Models.ClothingType.Coat);
            outfit.Coat.Picture = new Uri("http://upload.wikimedia.org/wikipedia/commons/2/2c/Fishtail_Parka.jpg");
            
            return PartialView("OutfitView", outfit);
        }
    }
}
