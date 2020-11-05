using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using WalkingTec.Mvvm.Core;

namespace ERCS.Models
{
    public enum VirusTypeEnum
    {
        DNA, RNA,SARS, Computer, 流行感冒
    }
    public class Virus: TopBasePoco
    {
        [Display(Name = "病毒名称")]
        [Required(ErrorMessage ="必须填病毒名称！")]//必填项
        public string VirusName { get; set; }

        [Display(Name = "病毒代号")]
        [Required(ErrorMessage = "必须填病毒代号！")]
        [StringLength(10,ErrorMessage ="病毒代号最多10个字符")]//字符限制长度
        public string VirusCode { get; set; }

        [Display(Name = "病毒描述")]
        public string VirusRemark { get; set; }

        [Display(Name = "病毒种类")]
        [Required(ErrorMessage = "必须填病毒种类！")]//
        public VirusTypeEnum? VirusType { get; set; }

        [Display(Name = "患者")]
        public List<PatientVirus> Patients { get; set; }//指向中间表
    }
    
}
