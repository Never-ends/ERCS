using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WalkingTec.Mvvm.Core;
using WalkingTec.Mvvm.Core.Extensions;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using ERCS.Models;


namespace ERCS.ViewModels.HospitalVMs
{
    public partial class HospitalListVM : BasePagedListVM<Hospital_View, HospitalSearcher>
    {
        protected override List<GridAction> InitGridAction()
        {
            return new List<GridAction>
            {
                this.MakeStandardAction("Hospital", GridActionStandardTypesEnum.Create, "新建","", dialogWidth: 800),
                this.MakeStandardAction("Hospital", GridActionStandardTypesEnum.Edit, "修改","", dialogWidth: 800),
                this.MakeStandardAction("Hospital", GridActionStandardTypesEnum.Delete, "删除", "",dialogWidth: 800),
                this.MakeStandardAction("Hospital", GridActionStandardTypesEnum.Details, "详细","", dialogWidth: 800),
                this.MakeStandardAction("Hospital", GridActionStandardTypesEnum.BatchEdit, "批量修改","", dialogWidth: 800),
                this.MakeStandardAction("Hospital", GridActionStandardTypesEnum.BatchDelete, "批量删除","", dialogWidth: 800),
                this.MakeStandardAction("Hospital", GridActionStandardTypesEnum.Import, "导入","", dialogWidth: 800),
                this.MakeStandardAction("Hospital", GridActionStandardTypesEnum.ExportExcel, "导出",""),
            };
        }

        protected override IEnumerable<IGridColumn<Hospital_View>> InitGridHeader()
        {
            return new List<GridColumn<Hospital_View>>{
                this.MakeGridHeader(x => x.Name),
                this.MakeGridHeader(x => x.Level),
                this.MakeGridHeader(x => x.Name_view),
                this.MakeGridHeaderAction(width: 200)
            };
        }

        public override IOrderedQueryable<Hospital_View> GetSearchQuery()
        {
            var query = DC.Set<Hospital>()
                .CheckContain(Searcher.Name, x=>x.Name)
                .CheckEqual(Searcher.Level, x=>x.Level)
                .Select(x => new Hospital_View
                {
				    ID = x.ID,
                    Name = x.Name,
                    Level = x.Level,
                    Name_view = x.Location.Name,
                })
                .OrderBy(x => x.ID);
            return query;
        }

    }

    public class Hospital_View : Hospital{
        [Display(Name = "名称")]
        public String Name_view { get; set; }

    }
}
