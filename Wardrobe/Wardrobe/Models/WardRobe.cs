using System.Collections.Generic;
using System.Linq;

namespace Wardrobe.Models
{
    public class WardRobe
    {
        private Dictionary<int, ClothingItem> clothingItemList = new Dictionary<int, ClothingItem>();
        private int LastId = 1;

        public WardRobe()
        {
            AddClothingItem("BlueShirt", ClothingType.Top, WeatherCondition.Any, Temperature.Any);
            AddClothingItem("GreenShirt", ClothingType.Top, WeatherCondition.Any, Temperature.Any);
            AddClothingItem("BlackJeans", ClothingType.Bottom, WeatherCondition.Sunny, Temperature.Mild);
            AddClothingItem("BlueJeans", ClothingType.Bottom, WeatherCondition.Sunny, Temperature.Mild);
            AddClothingItem("Khakis", ClothingType.Bottom, WeatherCondition.Sunny, Temperature.Mild);
            AddClothingItem("BlackWoolenCoat", ClothingType.Coat, WeatherCondition.Snow | WeatherCondition.Windy,
                            Temperature.Cold | Temperature.Freezing);
            AddClothingItem("PinkRainCoat", ClothingType.Coat,
                            WeatherCondition.Rainy | WeatherCondition.Windy | WeatherCondition.Cloudy,
                            Temperature.Mild | Temperature.Cold);
            AddClothingItem("TennisShoes", ClothingType.Shoes, WeatherCondition.Any, Temperature.Any);
            AddClothingItem("SummerHat", ClothingType.Hat, WeatherCondition.Sunny, Temperature.Any);
            AddClothingItem("WinterHat", ClothingType.Hat, WeatherCondition.Any, Temperature.Cold | Temperature.Freezing);
        }

        private ClothingItem AddClothingItem(string name, ClothingType clothingType, WeatherCondition weatherCondition,
                                             Temperature temperature)
        {
            return
                clothingItemList[LastId++] =
                new ClothingItem(LastId, name, clothingType, new Weather(weatherCondition, temperature));
        }


        public IEnumerable<ClothingItem> GetAllClothingItems()
        {
            return clothingItemList.Values;
        }

        public ClothingItem GetClothing(int id)
        {
            return clothingItemList[id];
        }

        public IEnumerable<ClothingItem> GetClothingFor(Weather weather)
        {
            return clothingItemList.Values.Where(p => p.Weather.Equals(weather));
        }

        public ClothingItem Get(ClothingType type)
        {
                    ClothingItem item;
            switch (type)
            {
                case ClothingType.Top:                   
                    item = GetClothing(1);
                    item.Picture = new System.Uri("http://www.downloadclipart.net/large/12218-blue-shirt-design.png");
                    break;
                case ClothingType.Bottom:
                    item = GetClothing(3);
                    item.Picture = new System.Uri("http://doodleslide.com/clipart/jeans.jpg");
                    break;
                case ClothingType.Hat:
                    item = GetClothing(9);
                    item.Picture = new System.Uri("http://upload.wikimedia.org/wikipedia/commons/2/23/Texas_Tech_Red_Raiders_baseball_cap.jpg");
                    break;
                case ClothingType.Shoes:
                    item = GetClothing(8);
                    item.Picture = new System.Uri("http://images.mytheresa.com/media/catalog/product/cache/common/image/1000x1000/b9336446c29edafc3474017303b51028/P/0/P00059051-GUM-NEON-HIGH-TOP-SNEAKERS-STANDARD.jpg");
                    break;
                case ClothingType.Coat:
                    item = GetClothing(6);
                    item.Picture = new System.Uri("http://upload.wikimedia.org/wikipedia/commons/2/2c/Fishtail_Parka.jpg");
                    break;
                default:
                    item = GetClothing(1);
                    break;
            }
            return item;
        }

    }

}