using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WalkingTec.Mvvm.Core;
using WalkingTec.Mvvm.Core.Extensions;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using ERCS.Models;


namespace ERCS.ViewModels.ControlCenterVMs
{
    public partial class ControlCenterListVM : BasePagedListVM<ControlCenter_View, ControlCenterSearcher>
    {
        protected override List<GridAction> InitGridAction()
        {
            return new List<GridAction>
            {
                this.MakeStandardAction("ControlCenter", GridActionStandardTypesEnum.Create, "新建","", dialogWidth: 800),
                this.MakeStandardAction("ControlCenter", GridActionStandardTypesEnum.Edit, "修改","", dialogWidth: 800),
                this.MakeStandardAction("ControlCenter", GridActionStandardTypesEnum.Delete, "删除", "",dialogWidth: 800),
                this.MakeStandardAction("ControlCenter", GridActionStandardTypesEnum.Details, "详细","", dialogWidth: 800),
                this.MakeStandardAction("ControlCenter", GridActionStandardTypesEnum.BatchEdit, "批量修改","", dialogWidth: 800),
                this.MakeStandardAction("ControlCenter", GridActionStandardTypesEnum.BatchDelete, "批量删除","", dialogWidth: 800),
                this.MakeStandardAction("ControlCenter", GridActionStandardTypesEnum.Import, "导入","", dialogWidth: 800),
                this.MakeStandardAction("ControlCenter", GridActionStandardTypesEnum.ExportExcel, "导出",""),
            };
        }

        protected override IEnumerable<IGridColumn<ControlCenter_View>> InitGridHeader()
        {
            return new List<GridColumn<ControlCenter_View>>{
                this.MakeGridHeader(x => x.Name),
                this.MakeGridHeader(x => x.Name_view),
                this.MakeGridHeaderAction(width: 200)
            };
        }

        public override IOrderedQueryable<ControlCenter_View> GetSearchQuery()
        {
            var query = DC.Set<ControlCenter>()
                .CheckEqual(Searcher.LocationId, x=>x.LocationId)
                .Select(x => new ControlCenter_View
                {
				    ID = x.ID,
                    Name = x.Name,
                    Name_view = x.Location.Name,
                })
                .OrderBy(x => x.ID);
            return query;
        }

    }

    public class ControlCenter_View : ControlCenter{
        [Display(Name = "名称")]
        public String Name_view { get; set; }

    }
}
