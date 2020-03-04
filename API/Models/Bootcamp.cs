using API.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models
{
    [Table("TB_M_Bootcamp")]
    public class Bootcamp : BaseModel
    {
        public string BootcampType { get; set; }
        public string RateScore { get; set; }
    }
}
