using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using WalkingTec.Mvvm.Core;
using WalkingTec.Mvvm.Core.Extensions;
using ERCS.Models;


namespace ERCS.ViewModels.HospitalVMs
{
    public partial class HospitalSearcher : BaseSearcher
    {
        [Display(Name = "医院名称")]
        public String Name { get; set; }
        [Display(Name = "医院等级")]
        public HospitalLevel? Level { get; set; }

        protected override void InitVM()
        {
        }

    }
}
