using API.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models
{
    [Table("TB_M_Question")]
    public class Question : BaseModel
    {
        public string Questions { get; set; }
        public string Type { get; set; }
    }
}
