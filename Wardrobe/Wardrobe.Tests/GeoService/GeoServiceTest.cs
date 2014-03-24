using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wardrobe.GeoService;

namespace Wardrobe.Tests.GeoService
{
    [TestClass]
    public class GeoServiceTest
    {
        [TestMethod]
        public void RedmondLocationTest()
        {
            float[] response = GeoServiceRequest.Get(98033);
            Assert.IsNotNull(response);
        }
    }
}
