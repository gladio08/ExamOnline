using API.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models
{
    [Table("TB_T_Answer")]
    public class Answer : BaseModel
    {
        public int? Participant_Id { get; set; }
        public string Answers { get; set; }
        public int? Question_Id { get; set; }
    }
}
