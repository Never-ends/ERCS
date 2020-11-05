using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WalkingTec.Mvvm.Core;
using ERCS.Controllers;
using ERCS.ViewModels.ControlCenterVMs;
using ERCS.Models;
using ERCS;

namespace ERCS.Test
{
    [TestClass]
    public class ControlCenterControllerTest
    {
        private ControlCenterController _controller;
        private string _seed;

        public ControlCenterControllerTest()
        {
            _seed = Guid.NewGuid().ToString();
            _controller = MockController.CreateController<ControlCenterController>(_seed, "user");
        }

        [TestMethod]
        public void SearchTest()
        {
            PartialViewResult rv = (PartialViewResult)_controller.Index();
            Assert.IsInstanceOfType(rv.Model, typeof(IBasePagedListVM<TopBasePoco, BaseSearcher>));
            string rv2 = _controller.Search(rv.Model as ControlCenterListVM);
            Assert.IsTrue(rv2.Contains("\"Code\":200"));
        }

        [TestMethod]
        public void CreateTest()
        {
            PartialViewResult rv = (PartialViewResult)_controller.Create();
            Assert.IsInstanceOfType(rv.Model, typeof(ControlCenterVM));

            ControlCenterVM vm = rv.Model as ControlCenterVM;
            ControlCenter v = new ControlCenter();
			
            v.Name = "Xf8E";
            v.LocationId = AddLocation();
            vm.Entity = v;
            _controller.Create(vm);

            using (var context = new DataContext(_seed, DBTypeEnum.Memory))
            {
                var data = context.Set<ControlCenter>().FirstOrDefault();
				
                Assert.AreEqual(data.Name, "Xf8E");
            }

        }

        [TestMethod]
        public void EditTest()
        {
            ControlCenter v = new ControlCenter();
            using (var context = new DataContext(_seed, DBTypeEnum.Memory))
            {
       			
                v.Name = "Xf8E";
                v.LocationId = AddLocation();
                context.Set<ControlCenter>().Add(v);
                context.SaveChanges();
            }

            PartialViewResult rv = (PartialViewResult)_controller.Edit(v.ID.ToString());
            Assert.IsInstanceOfType(rv.Model, typeof(ControlCenterVM));

            ControlCenterVM vm = rv.Model as ControlCenterVM;
            v = new ControlCenter();
            v.ID = vm.Entity.ID;
       		
            v.Name = "XEWa3RXS";
            vm.Entity = v;
            vm.FC = new Dictionary<string, object>();
			
            vm.FC.Add("Entity.Name", "");
            vm.FC.Add("Entity.LocationId", "");
            _controller.Edit(vm);

            using (var context = new DataContext(_seed, DBTypeEnum.Memory))
            {
                var data = context.Set<ControlCenter>().FirstOrDefault();
 				
                Assert.AreEqual(data.Name, "XEWa3RXS");
            }

        }


        [TestMethod]
        public void DeleteTest()
        {
            ControlCenter v = new ControlCenter();
            using (var context = new DataContext(_seed, DBTypeEnum.Memory))
            {
        		
                v.Name = "Xf8E";
                v.LocationId = AddLocation();
                context.Set<ControlCenter>().Add(v);
                context.SaveChanges();
            }

            PartialViewResult rv = (PartialViewResult)_controller.Delete(v.ID.ToString());
            Assert.IsInstanceOfType(rv.Model, typeof(ControlCenterVM));

            ControlCenterVM vm = rv.Model as ControlCenterVM;
            v = new ControlCenter();
            v.ID = vm.Entity.ID;
            vm.Entity = v;
            _controller.Delete(v.ID.ToString(),null);

            using (var context = new DataContext(_seed, DBTypeEnum.Memory))
            {
                Assert.AreEqual(context.Set<ControlCenter>().Count(), 0);
            }

        }


        [TestMethod]
        public void DetailsTest()
        {
            ControlCenter v = new ControlCenter();
            using (var context = new DataContext(_seed, DBTypeEnum.Memory))
            {
				
                v.Name = "Xf8E";
                v.LocationId = AddLocation();
                context.Set<ControlCenter>().Add(v);
                context.SaveChanges();
            }
            PartialViewResult rv = (PartialViewResult)_controller.Details(v.ID.ToString());
            Assert.IsInstanceOfType(rv.Model, typeof(IBaseCRUDVM<TopBasePoco>));
            Assert.AreEqual(v.ID, (rv.Model as IBaseCRUDVM<TopBasePoco>).Entity.GetID());
        }

        [TestMethod]
        public void BatchDeleteTest()
        {
            ControlCenter v1 = new ControlCenter();
            ControlCenter v2 = new ControlCenter();
            using (var context = new DataContext(_seed, DBTypeEnum.Memory))
            {
				
                v1.Name = "Xf8E";
                v1.LocationId = AddLocation();
                v2.Name = "XEWa3RXS";
                v2.LocationId = v1.LocationId; 
                context.Set<ControlCenter>().Add(v1);
                context.Set<ControlCenter>().Add(v2);
                context.SaveChanges();
            }

            PartialViewResult rv = (PartialViewResult)_controller.BatchDelete(new string[] { v1.ID.ToString(), v2.ID.ToString() });
            Assert.IsInstanceOfType(rv.Model, typeof(ControlCenterBatchVM));

            ControlCenterBatchVM vm = rv.Model as ControlCenterBatchVM;
            vm.Ids = new string[] { v1.ID.ToString(), v2.ID.ToString() };
            _controller.DoBatchDelete(vm, null);

            using (var context = new DataContext(_seed, DBTypeEnum.Memory))
            {
                Assert.AreEqual(context.Set<ControlCenter>().Count(), 0);
            }
        }

        private Guid AddLocation()
        {
            City v = new City();
            using (var context = new DataContext(_seed, DBTypeEnum.Memory))
            {

                v.Name = "EqV";
                context.Set<City>().Add(v);
                context.SaveChanges();
            }
            return v.ID;
        }


    }
}
