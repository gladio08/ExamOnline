using API.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models
{
    [Table("TB_M_Choice")]
    public class Choice : BaseModel
    {
        public string Choices { get; set; }
        public int? Question_Id { get; set; }
    }
}
