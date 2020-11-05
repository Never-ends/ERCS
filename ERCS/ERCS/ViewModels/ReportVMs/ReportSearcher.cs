using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using WalkingTec.Mvvm.Core;
using WalkingTec.Mvvm.Core.Extensions;
using ERCS.Models;


namespace ERCS.ViewModels.ReportVMs
{
    public partial class ReportSearcher : BaseSearcher
    {
        public List<ComboSelectListItem> AllPatients { get; set; }
        public int? PatientID { get; set; }

        protected override void InitVM()
        {
            AllPatients = DC.Set<Patient>().GetSelectListItems(LoginUserInfo?.DataPrivileges, null, y => y.PatientName);
        }

    }
}
