using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using WalkingTec.Mvvm.Core;
using WalkingTec.Mvvm.Core.Extensions;
using ERCS.Models;


namespace ERCS.ViewModels.PatientVMs
{
    public partial class PatientBatchVM : BaseBatchVM<Patient, Patient_BatchEdit>
    {
        public PatientBatchVM()
        {
            ListVM = new PatientListVM();
            LinkedVM = new Patient_BatchEdit();
        }

    }

	/// <summary>
    /// 批量编辑字段类
    /// </summary>
    public class Patient_BatchEdit : BaseVM
    {

        protected override void InitVM()
        {
        }

    }

}
