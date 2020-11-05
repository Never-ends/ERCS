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
    public partial class ControlCenterSearcher : BaseSearcher
    {
        public List<ComboSelectListItem> AllLocations { get; set; }
        [Display(Name = "疾控中心地点")]
        public Guid? LocationId { get; set; }

        protected override void InitVM()
        {
            AllLocations = DC.Set<City>().GetSelectListItems(LoginUserInfo?.DataPrivileges, null, y => y.Name);
        }

    }
}
