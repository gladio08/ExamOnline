using API.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models
{
    [Table("TB_M_TestTime")]
    public class TestTime : BaseModel
    {
        public int? Participant_Id { get; set; }
        public DateTime TestDate { get; set; }
    }
}
