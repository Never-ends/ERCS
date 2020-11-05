﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using ERCS.Controllers;
using ERCS.ViewModels.HomeVMs;

namespace ERCS.Test
{
    [TestClass]
    public class HomeControllerTest
    {
        private HomeController _controller;
        private string _seed;

        public HomeControllerTest()
        {
            _seed = Guid.NewGuid().ToString();
            _controller = MockController.CreateController<HomeController>(_seed, "user");
        }

        [TestMethod]
        public void PIndexTest()
        {
            ViewResult rv = (ViewResult)_controller.PIndex();
            //测试是否正确返回
            Assert.IsNotNull(rv);
        }

        [TestMethod]
        public void FrontPageTest()
        {
            PartialViewResult rv = (PartialViewResult)_controller.FrontPage();
            //测试是否正确返回
            Assert.IsNotNull(rv);
        }
    }
}
