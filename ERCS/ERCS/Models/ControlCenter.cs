using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using WalkingTec.Mvvm.Core;

namespace ERCS.Models
{
    public class ControlCenter : TopBasePoco//疾控中心
    {
        [Display(Name = "疾控中心名称")]
        [Required(ErrorMessage = "疾控中心名称是必填项")]
        public string Name { get; set; }

        [Display(Name = "疾控中心地点")]
        public City Location { get; set; }
        [Display(Name = "疾控中心地点")]
        [Required(ErrorMessage = "疾控中心地点是必填项")]
        public Guid? LocationId { get; set; }

    }
}
