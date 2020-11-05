using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WalkingTec.Mvvm.Core;
using WalkingTec.Mvvm.Core.Attributes;

namespace ERCS.Models
{
    [MiddleTable]//用于生成多对多的中间表
    public class PatientVirus : TopBasePoco
    {
        public Patient Patient { get; set; }//患者表
        public int PatientId { get; set; }


        public Virus Virus { get; set; }//病毒表
        public Guid VirusId { get; set; }


    }
}
