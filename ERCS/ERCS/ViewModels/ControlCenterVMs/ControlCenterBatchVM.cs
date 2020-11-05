using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using WalkingTec.Mvvm.Core;
using WalkingTec.Mvvm.Core.Extensions;
using ERCS.Models;


namespace ERCS.ViewModels.ControlCenterVMs
{
    public partial class ControlCenterBatchVM : BaseBatchVM<ControlCenter, ControlCenter_BatchEdit>
    {
        public ControlCenterBatchVM()
        {
            ListVM = new ControlCenterListVM();
            LinkedVM = new ControlCenter_BatchEdit();
        }

    }

	/// <summary>
    /// 批量编辑字段类
    /// </summary>
    public class ControlCenter_BatchEdit : BaseVM
    {

        protected override void InitVM()
        {
        }

    }

}
