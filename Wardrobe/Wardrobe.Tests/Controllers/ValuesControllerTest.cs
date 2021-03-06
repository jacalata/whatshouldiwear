﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Web.Http;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Wardrobe;
using Wardrobe.Controllers;
using Wardrobe.Models;

namespace Wardrobe.Tests.Controllers
{
    [TestClass]
    public class ValuesControllerTest
    {
        [TestMethod]
        public void Get()
        {
            // Arrange
            WardRobeController controller = new WardRobeController();

            // Act
            IEnumerable<ClothingItem> result = controller.GetAll();

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(2, result.Count());
            Assert.AreEqual("value1", result.ElementAt(0));
            Assert.AreEqual("value2", result.ElementAt(1));
        }

        [TestMethod]
        public void GetById()
        {
            // Arrange
            WardRobeController controller = new WardRobeController();

            // Act
            string result = controller.Get(5).Name;

            // Assert
            Assert.AreEqual("value", result);
        }

        [TestMethod]
        public void Post()
        {
            // Arrange
            WardRobeController controller = new WardRobeController();

            // Act
            controller.Post("value");

            // Assert
        }

        [TestMethod]
        public void Put()
        {
            // Arrange
            WardRobeController controller = new WardRobeController();

            // Act
            controller.Put(5, "value");

            // Assert
        }

        [TestMethod]
        public void Delete()
        {
            // Arrange
            WardRobeController controller = new WardRobeController();

            // Act
            controller.Delete(5);

            // Assert
        }
    }
}
