using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExamOnline.viewModels
{
    public class ChoiceVM
    {
        public string id { get; set; }
        public string Choices { get; set; }
        public int? Question_Id { get; set; }
    }
}
