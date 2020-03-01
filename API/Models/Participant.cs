using API.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models
{
    [Table("TB_M_Participant")]
    public class Participant : BaseModel
    {
        public string Name { get; set; }
        public string Graduate { get; set; }
        public string University { get; set; }
        public string GPA { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public DateTime RegisterDate { get; set; }
        public int? User_Id { get; set; }


    }
}
