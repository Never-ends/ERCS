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
    public partial class PatientSearcher : BaseSearcher
    {
        public List<ComboSelectListItem> AllLocations { get; set; }
        [Display(Name = "籍贯")]
        public Guid? LocationId { get; set; }
        public List<ComboSelectListItem> AllHospitals { get; set; }
        [Display(Name = "所属医院")]
        public Guid? HospitalId { get; set; }
        public List<ComboSelectListItem> AllVirusess { get; set; }
        [Display(Name = "病毒")]
        public List<Guid> SelectedVirusesIDs { get; set; }

        protected override void InitVM()
        {
            AllLocations = DC.Set<City>().GetSelectListItems(LoginUserInfo?.DataPrivileges, null, y => y.Name);
            AllHospitals = DC.Set<Hospital>().GetSelectListItems(LoginUserInfo?.DataPrivileges, null, y => y.Name);
            AllVirusess = DC.Set<Virus>().GetSelectListItems(LoginUserInfo?.DataPrivileges, null, y => y.VirusName);
        }

    }
}
