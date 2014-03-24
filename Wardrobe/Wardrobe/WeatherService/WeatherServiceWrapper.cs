using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ForecastIO;
using Wardrobe.Models;

namespace Wardrobe.WeatherService
{
    public static class WeatherServiceWrapper
    {
        //DO NOT TOUCH
        private const string API_KEY = "2b9e4f5b9f8bd0850ea6e31eb388ad8b";

        /// <summary>
        /// Gets daily weather conditions given latitude and longitude. Currently synchronous
        /// </summary>
        /// <param name="latitude">lat</param>
        /// <param name="longitude">long</param>
        /// <returns>Weather object with condition and temperature from weather service</returns>
        public static Weather GetWeather(float latitude, float longitude)
        {
            var request = new ForecastIORequest(API_KEY, latitude, longitude, DateTime.Now, Unit.us);
            var response = request.Get();

            DailyForecast forecast = response.daily.data.First();


            Temperature temperature = WeatherServiceHelper.GetDailyTemperature(forecast.apparentTemperatureMin, forecast.apparentTemperatureMax);
            WeatherCondition condition = WeatherServiceHelper.GetDailyCondition(forecast.icon);

            return new Weather(condition, temperature);
        }
    }
}