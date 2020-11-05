using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WalkingTec.Mvvm.Core;
using WalkingTec.Mvvm.Core.Extensions;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using ERCS.Models;


namespace ERCS.ViewModels.VirusVMs
{
    public partial class VirusListVM : BasePagedListVM<Virus_View, VirusSearcher>
    {
        protected override List<GridAction> InitGridAction()
        {
            return new List<GridAction>
            {
                this.MakeStandardAction("Virus", GridActionStandardTypesEnum.Create, "新建","", dialogWidth: 800),
                this.MakeStandardAction("Virus", GridActionStandardTypesEnum.Edit, "修改","", dialogWidth: 800),
                this.MakeStandardAction("Virus", GridActionStandardTypesEnum.Delete, "删除", "",dialogWidth: 800),
                this.MakeStandardAction("Virus", GridActionStandardTypesEnum.Details, "详细","", dialogWidth: 800),
                this.MakeStandardAction("Virus", GridActionStandardTypesEnum.BatchEdit, "批量修改","", dialogWidth: 800),
                this.MakeStandardAction("Virus", GridActionStandardTypesEnum.BatchDelete, "批量删除","", dialogWidth: 800),
                this.MakeStandardAction("Virus", GridActionStandardTypesEnum.Import, "导入","", dialogWidth: 800),
                this.MakeStandardAction("Virus", GridActionStandardTypesEnum.ExportExcel, "导出",""),
            };
        }

        protected override IEnumerable<IGridColumn<Virus_View>> InitGridHeader()
        {
            return new List<GridColumn<Virus_View>>{
                this.MakeGridHeader(x => x.VirusName),
                this.MakeGridHeader(x => x.VirusRemark),
                this.MakeGridHeader(x => x.VirusType),
                this.MakeGridHeaderAction(width: 200)
            };
        }

        public override IOrderedQueryable<Virus_View> GetSearchQuery()
        {
            var query = DC.Set<Virus>()
                .CheckContain(Searcher.VirusName, x=>x.VirusName)
                .CheckContain(Searcher.VirusRemark, x=>x.VirusRemark)
                .CheckEqual(Searcher.VirusType, x=>x.VirusType)
                .Select(x => new Virus_View
                {
				    ID = x.ID,
                    VirusName = x.VirusName,
                    VirusRemark = x.VirusRemark,
                    VirusType = x.VirusType,
                })
                .OrderBy(x => x.ID);
            return query;
        }

    }

    public class Virus_View : Virus{

    }
}
