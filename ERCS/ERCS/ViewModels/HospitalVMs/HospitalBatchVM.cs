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
    public partial class HospitalBatchVM : BaseBatchVM<Hospital, Hospital_BatchEdit>
    {
        public HospitalBatchVM()
        {
            ListVM = new HospitalListVM();
            LinkedVM = new Hospital_BatchEdit();
        }

    }

	/// <summary>
    /// 批量编辑字段类
    /// </summary>
    public class Hospital_BatchEdit : BaseVM
    {

        protected override void InitVM()
        {
        }

    }

}
