using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using WalkingTec.Mvvm.Core;

namespace ERCS.Models
{
    public class City : TopBasePoco,ITreeData<City>//泛型树形结构
    {
        [Display(Name = "名称")]
        [Required(ErrorMessage = "必须填名称！")]//必填项
        public string Name { get; set; }

        public List<City> Children { get; set; }

        [Display(Name = "父级")]
        public City Parent { get; set; }
        [Display(Name = "父级")]
        public Guid? ParentId { get; set; }
        //关联自身外键
    }


}
