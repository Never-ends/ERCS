using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WalkingTec.Mvvm.Core;
using ERCS.Controllers;
using ERCS.ViewModels.HospitalVMs;
using ERCS.Models;
using ERCS;

namespace ERCS.Test
{
    [TestClass]
    public class HospitalControllerTest
    {
        private HospitalController _controller;
        private string _seed;

        public HospitalControllerTest()
        {
            _seed = Guid.NewGuid().ToString();
            _controller = MockController.CreateController<HospitalController>(_seed, "user");
        }

        [TestMethod]
        public void SearchTest()
        {
            PartialViewResult rv = (PartialViewResult)_controller.Index();
            Assert.IsInstanceOfType(rv.Model, typeof(IBasePagedListVM<TopBasePoco, BaseSearcher>));
            string rv2 = _controller.Search(rv.Model as HospitalListVM);
            Assert.IsTrue(rv2.Contains("\"Code\":200"));
        }

        [TestMethod]
        public void CreateTest()
        {
            PartialViewResult rv = (PartialViewResult)_controller.Create();
            Assert.IsInstanceOfType(rv.Model, typeof(HospitalVM));

            HospitalVM vm = rv.Model as HospitalVM;
            Hospital v = new Hospital();
			
            v.Name = "lm862zt";
            v.LocationId = AddLocation();
            vm.Entity = v;
            _controller.Create(vm);

            using (var context = new DataContext(_seed, DBTypeEnum.Memory))
            {
                var data = context.Set<Hospital>().FirstOrDefault();
				
                Assert.AreEqual(data.Name, "lm862zt");
            }

        }

        [TestMethod]
        public void EditTest()
        {
            Hospital v = new Hospital();
            using (var context = new DataContext(_seed, DBTypeEnum.Memory))
            {
       			
                v.Name = "lm862zt";
                v.LocationId = AddLocation();
                context.Set<Hospital>().Add(v);
                context.SaveChanges();
            }

            PartialViewResult rv = (PartialViewResult)_controller.Edit(v.ID.ToString());
            Assert.IsInstanceOfType(rv.Model, typeof(HospitalVM));

            HospitalVM vm = rv.Model as HospitalVM;
            v = new Hospital();
            v.ID = vm.Entity.ID;
       		
            v.Name = "vS52b3xZp";
            vm.Entity = v;
            vm.FC = new Dictionary<string, object>();
			
            vm.FC.Add("Entity.Name", "");
            vm.FC.Add("Entity.LocationId", "");
            _controller.Edit(vm);

            using (var context = new DataContext(_seed, DBTypeEnum.Memory))
            {
                var data = context.Set<Hospital>().FirstOrDefault();
 				
                Assert.AreEqual(data.Name, "vS52b3xZp");
            }

        }


        [TestMethod]
        public void DeleteTest()
        {
            Hospital v = new Hospital();
            using (var context = new DataContext(_seed, DBTypeEnum.Memory))
            {
        		
                v.Name = "lm862zt";
                v.LocationId = AddLocation();
                context.Set<Hospital>().Add(v);
                context.SaveChanges();
            }

            PartialViewResult rv = (PartialViewResult)_controller.Delete(v.ID.ToString());
            Assert.IsInstanceOfType(rv.Model, typeof(HospitalVM));

            HospitalVM vm = rv.Model as HospitalVM;
            v = new Hospital();
            v.ID = vm.Entity.ID;
            vm.Entity = v;
            _controller.Delete(v.ID.ToString(),null);

            using (var context = new DataContext(_seed, DBTypeEnum.Memory))
            {
                Assert.AreEqual(context.Set<Hospital>().Count(), 0);
            }

        }


        [TestMethod]
        public void DetailsTest()
        {
            Hospital v = new Hospital();
            using (var context = new DataContext(_seed, DBTypeEnum.Memory))
            {
				
                v.Name = "lm862zt";
                v.LocationId = AddLocation();
                context.Set<Hospital>().Add(v);
                context.SaveChanges();
            }
            PartialViewResult rv = (PartialViewResult)_controller.Details(v.ID.ToString());
            Assert.IsInstanceOfType(rv.Model, typeof(IBaseCRUDVM<TopBasePoco>));
            Assert.AreEqual(v.ID, (rv.Model as IBaseCRUDVM<TopBasePoco>).Entity.GetID());
        }

        [TestMethod]
        public void BatchDeleteTest()
        {
            Hospital v1 = new Hospital();
            Hospital v2 = new Hospital();
            using (var context = new DataContext(_seed, DBTypeEnum.Memory))
            {
				
                v1.Name = "lm862zt";
                v1.LocationId = AddLocation();
                v2.Name = "vS52b3xZp";
                v2.LocationId = v1.LocationId; 
                context.Set<Hospital>().Add(v1);
                context.Set<Hospital>().Add(v2);
                context.SaveChanges();
            }

            PartialViewResult rv = (PartialViewResult)_controller.BatchDelete(new string[] { v1.ID.ToString(), v2.ID.ToString() });
            Assert.IsInstanceOfType(rv.Model, typeof(HospitalBatchVM));

            HospitalBatchVM vm = rv.Model as HospitalBatchVM;
            vm.Ids = new string[] { v1.ID.ToString(), v2.ID.ToString() };
            _controller.DoBatchDelete(vm, null);

            using (var context = new DataContext(_seed, DBTypeEnum.Memory))
            {
                Assert.AreEqual(context.Set<Hospital>().Count(), 0);
            }
        }

        private Guid AddLocation()
        {
            City v = new City();
            using (var context = new DataContext(_seed, DBTypeEnum.Memory))
            {

                v.Name = "ZaNtzyTQ";
                context.Set<City>().Add(v);
                context.SaveChanges();
            }
            return v.ID;
        }


    }
}
