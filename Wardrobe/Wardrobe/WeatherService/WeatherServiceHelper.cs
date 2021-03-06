﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Wardrobe.Models;

namespace Wardrobe.WeatherService
{
    public static class WeatherServiceHelper
    {
        public const float REDMOND_LATITUDE = 47.6694f;
        public const float REDMOND_LONGITUDE = -122.1239f;

        //Represents the maximum temperature for each enum value
        private const float FREEZING = 32f;
        private const float COLD = 65f;
        private const float MILD = 85f;
        private const float HOT = 100f;
        //Scorching is anything over 100
        

        public static Temperature GetDailyTemperature(float min, float max)
        {
            float avgTemp = (min + max) / 2;
            if (avgTemp < FREEZING) return Temperature.Freezing;
            else if (avgTemp < COLD) return Temperature.Cold;
            else if (avgTemp < MILD) return Temperature.Mild;
            else if (avgTemp < HOT) return Temperature.Hot;
            else return Temperature.Scorching;
        }

        private static string[] Sunny = {"clear-day", "clear-night"};
        private static string[] Rainy = { "rain" };
        private static string[] Snow = { "snow", "sleet" };
        private static string[] Windy = { "wind" };
        private static string[] Cloudy = { "fog", "cloudy", "partly-cloudy-day", "partly-cloudy-night" };

        public static WeatherCondition GetDailyCondition(string condition)
        {
            if (Sunny.Contains(condition)) return WeatherCondition.Sunny;
            else if (Rainy.Contains(condition)) return WeatherCondition.Rainy;
            else if (Snow.Contains(condition)) return WeatherCondition.Snow;
            else if (Windy.Contains(condition)) return WeatherCondition.Windy;
            else if (Cloudy.Contains(condition)) return WeatherCondition.Cloudy;
            else return WeatherCondition.Any;
        }
    }
}