using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Web.Http;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Wardrobe;
using Wardrobe.Controllers;
using Wardrobe.Models;
using Wardrobe.WeatherService;

namespace Wardrobe.Tests.WeatherService
{
    [TestClass]
    public class WeatherServiceTest
    {
        [TestMethod]
        public void GetRedmondWeather()
        {
            Weather weather = WeatherServiceWrapper.GetWeather(WeatherServiceHelper.REDMOND_LATITUDE, WeatherServiceHelper.REDMOND_LONGITUDE);
            Assert.IsTrue(weather.Temperature == Temperature.Cold || weather.Temperature == Temperature.Mild);
            Assert.IsTrue(weather.WeatherCondition == WeatherCondition.Cloudy || weather.WeatherCondition == WeatherCondition.Sunny);
        }
    }
}
