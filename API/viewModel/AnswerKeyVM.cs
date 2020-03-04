using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace API.viewModel
{
    [Table("TB_M_AnswerKey")]
    public class AnswerKeyVM
    {
        public int Id { get; set; }
        public int Question_Id { get; set; }
        public string Questions { get; set; }
        public string TrueAnswer { get; set; }
        public string Score { get; set; }
    }
}
