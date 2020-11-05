using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using WalkingTec.Mvvm.Core;

namespace ERCS.Models
{   //继承BasePoco可以自动化生成createtime等自增主键
    public class Report : BasePoco//记录病人状况
    {
        [Required(ErrorMessage = "体温是必填项")]
        [Range(30, 50, ErrorMessage = "体温必须在30到50度之间")]
        [Display(Name = "体温")]
        public float? Temprature { get; set; }

        [Display(Name = "备注")]
        public string Remark { get; set; }
        public Patient Patient { get; set; }
        [Display(Name = "患者")]
        [Required(ErrorMessage = "患者是必填项")]
        public int? PatientID { get; set; }//Guid?
    }
}
