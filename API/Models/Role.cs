using API.Base;
using API.viewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace API.Model
{
    [Table("TB_M_Role")]
    public class Role : BaseModel
    {
        public string Name { get; set; }
    }
}
