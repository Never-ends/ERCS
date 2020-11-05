using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using WalkingTec.Mvvm.Core;

namespace ERCS.Models
{
    public enum GenderEnum
    {
        [Display(Name = "男")]
        Male,
        [Display(Name = "女")]
        Female
    }

    public enum PatientStatusEnum
    {
        [Display(Name = "无症状")]
        WuZhengZhuang,
        [Display(Name = "疑似")]
        YiSi,
        [Display(Name = "确诊")]
        QueZhen,
        [Display(Name = "治愈")]
        ZhiYu,
        [Display(Name = "死亡")]
        SiWang
    }

    [Table("MyPatients")]//手写sql语句才用，一搬不用
    public class Patient : PersistPoco
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public new int ID { get; set; }

        [Display(Name = "患者姓名")]
        [Required(ErrorMessage = "患者姓名是必填项")]
        public string PatientName { get; set; }

        [Display(Name = "身份证")]
        [Required(ErrorMessage = "身份证是必填项")]//身份证正则表达式
        [RegularExpression("^(\\d{18,18}|\\d{15,15}|\\d{17,17}x)", ErrorMessage = "身份证格式不对")]
        public string IdNumber { get; set; }

        [Display(Name = "性别")]
        public GenderEnum? Gender { get; set; }

        [Display(Name = "状态")]
        [Required(ErrorMessage = "状态是必填项")]
        public PatientStatusEnum? Status { get; set; }
        [Display(Name = "生日")]
        public DateTime? Birthday { get; set; }


        [Display(Name = "籍贯")]
        public City Location { get; set; }
        [Display(Name = "籍贯")]
        public Guid? LocationId { get; set; }


        [Display(Name = "所属医院")]
        public Hospital Hospital { get; set; }
        [Display(Name = "所属医院")]
        public Guid? HospitalId { get; set; }

        public FileAttachment Photo { get; set; }
        [Display(Name = "照片")]
        public Guid? PhotoId { get; set; }

        [Display(Name = "病毒")]
        public List<PatientVirus> Viruses { get; set; }//定义list指向中间表

        [NotMapped]//不在数据库生成
        [Display(Name = "年龄")]
        public int Age
        {
            get
            {
                if (Birthday.HasValue)
                {
                    return DateTime.Now.Year - Birthday.Value.Year;
                }
                return 0;
            }
        }
    }
}
