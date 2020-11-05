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
    public partial class ReportTemplateVM : BaseTemplateVM
    {
        [Display(Name = "体温")]
        public ExcelPropety Temprature_Excel = ExcelPropety.CreateProperty<Report>(x => x.Temprature);
        [Display(Name = "备注")]
        public ExcelPropety Remark_Excel = ExcelPropety.CreateProperty<Report>(x => x.Remark);
        public ExcelPropety Patient_Excel = ExcelPropety.CreateProperty<Report>(x => x.PatientID);

	    protected override void InitVM()
        {
            Patient_Excel.DataType = ColumnDataType.ComboBox;
            Patient_Excel.ListItems = DC.Set<Patient>().GetSelectListItems(LoginUserInfo?.DataPrivileges, null, y => y.PatientName);
        }

    }

    public class ReportImportVM : BaseImportVM<ReportTemplateVM, Report>
    {

    }

}
