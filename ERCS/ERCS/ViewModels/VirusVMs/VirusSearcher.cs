using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using WalkingTec.Mvvm.Core;
using WalkingTec.Mvvm.Core.Extensions;
using ERCS.Models;


namespace ERCS.ViewModels.VirusVMs
{
    public partial class VirusSearcher : BaseSearcher
    {
        [Display(Name = "病毒名称")]
        public String VirusName { get; set; }
        [Display(Name = "病毒描述")]
        public String VirusRemark { get; set; }
        [Display(Name = "病毒种类")]
        public VirusTypeEnum? VirusType { get; set; }

        protected override void InitVM()
        {
        }

    }
}
