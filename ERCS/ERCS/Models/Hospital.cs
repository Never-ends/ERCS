using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using WalkingTec.Mvvm.Core;

namespace ERCS.Models
{
    public enum HospitalLevel //枚举医院等级
    {
        [Display(Name ="丙等医院")]
        Class3,
        [Display(Name = "乙等医院")]
        Class2,
        [Display(Name = "甲等医院")]
        Class1,

    }
    public class Hospital : TopBasePoco
    {
        [Display(Name = "医院名称")]
        [Required(ErrorMessage = "必须填医院名称！")]//必填项
        public string Name { get; set; }

        [Display(Name = "医院等级")]
        [Required(ErrorMessage = "必须填医院等级！")]//必填项
        public HospitalLevel? Level { get; set; }

        [Display(Name = "医院地点")]
        public City Location { get; set; }//与city表绑定

        [Display(Name = "医院区号")]
        [Required(ErrorMessage = "必须填医院区号！")]//必填项
        public Guid? LocationId { get; set; }//同时指定外键,？允许为空
    }
}
