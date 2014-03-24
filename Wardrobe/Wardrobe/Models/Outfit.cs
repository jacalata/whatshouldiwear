using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Wardrobe.Models
{
    public class Outfit
    {
        // hat, coat, shoes, top, bottom
        public ClothingItem Hat { get; set; }
        public ClothingItem Coat { get; set; }
        public ClothingItem Shoes { get; set; }
        public ClothingItem Top { get; set; }
        public ClothingItem Bottom { get; set; }

    }
}