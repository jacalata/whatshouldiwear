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
    }

}