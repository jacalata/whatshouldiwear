using System;

namespace Wardrobe.Models
{
    [Flags]
    public enum WeatherCondition
    {
        Rainy = 0,
        Sunny = 1,
        Cloudy = 2,
        Windy = 4,
        Snow = 8,
        Any = Rainy | Sunny | Cloudy | Windy | Snow
    }
}