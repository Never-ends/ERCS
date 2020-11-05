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
    public partial class VirusBatchVM : BaseBatchVM<Virus, Virus_BatchEdit>
    {
        public VirusBatchVM()
        {
            ListVM = new VirusListVM();
            LinkedVM = new Virus_BatchEdit();
        }

    }

	/// <summary>
    /// 批量编辑字段类
    /// </summary>
    public class Virus_BatchEdit : BaseVM
    {
        [Display(Name = "病毒种类")]
        public VirusTypeEnum? VirusType { get; set; }

        protected override void InitVM()
        {
        }

    }

}
