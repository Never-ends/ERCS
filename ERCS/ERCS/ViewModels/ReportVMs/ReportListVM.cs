using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WalkingTec.Mvvm.Core;
using WalkingTec.Mvvm.Core.Extensions;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using ERCS.Models;


namespace ERCS.ViewModels.ReportVMs
{
    public partial class ReportListVM : BasePagedListVM<Report_View, ReportSearcher>
    {
        protected override List<GridAction> InitGridAction()
        {
            return new List<GridAction>
            {
                this.MakeStandardAction("Report", GridActionStandardTypesEnum.Create, "新建","", dialogWidth: 800),
                this.MakeStandardAction("Report", GridActionStandardTypesEnum.Edit, "修改","", dialogWidth: 800),
                this.MakeStandardAction("Report", GridActionStandardTypesEnum.Delete, "删除", "",dialogWidth: 800),
                this.MakeStandardAction("Report", GridActionStandardTypesEnum.Details, "详细","", dialogWidth: 800),
                this.MakeStandardAction("Report", GridActionStandardTypesEnum.BatchEdit, "批量修改","", dialogWidth: 800),
                this.MakeStandardAction("Report", GridActionStandardTypesEnum.BatchDelete, "批量删除","", dialogWidth: 800),
                this.MakeStandardAction("Report", GridActionStandardTypesEnum.Import, "导入","", dialogWidth: 800),
                this.MakeStandardAction("Report", GridActionStandardTypesEnum.ExportExcel, "导出",""),
            };
        }

        protected override IEnumerable<IGridColumn<Report_View>> InitGridHeader()
        {
            return new List<GridColumn<Report_View>>{
                this.MakeGridHeader(x => x.Temprature),
                this.MakeGridHeader(x => x.Remark),
                this.MakeGridHeader(x => x.PatientName_view),
                this.MakeGridHeaderAction(width: 200)
            };
        }

        public override IOrderedQueryable<Report_View> GetSearchQuery()
        {
            var query = DC.Set<Report>()
                .CheckEqual(Searcher.PatientID, x=>x.PatientID)
                .Select(x => new Report_View
                {
				    ID = x.ID,
                    Temprature = x.Temprature,
                    Remark = x.Remark,
                    PatientName_view = x.Patient.PatientName,
                })
                .OrderBy(x => x.ID);
            return query;
        }

    }

    public class Report_View : Report{
        [Display(Name = "患者姓名")]
        public String PatientName_view { get; set; }

    }
}
