using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace API.Base
{
    public interface IEntity
    {
        [Key]
        int Id { get; set; }
        bool IsDelete { get; }

        void Create();
        void Update();
        void Delete();
    }
}
