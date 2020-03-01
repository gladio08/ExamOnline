using API.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models
{
    [Table("TB_M_AnswerKey")]
    public class AnswerKey : BaseModel
    {
        public int? Question_Id { get; set; }
        public string TrueAnswer { get; set; }
        public string Score { get; set; }
    }
}
