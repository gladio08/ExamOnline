using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Base;
using API.Model;
using API.Repositories.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RolesController : BasesController<Role, RoleRepository>
    {
        private readonly RoleRepository _repository;
        public RolesController(RoleRepository roleRepository) : base(roleRepository)
        {
            _repository = roleRepository;
        }

        [HttpPost]
        [Route("Post")]
        public async Task<IActionResult> Post(Role role)
        {
            var get = await _repository.Get();
            get = get.Where(a => a.Name.Equals(role.Name)).ToList();
            if (get.Count() > 0)
            {
                return BadRequest();
            }
            else
            {
                role.Create();
                var create = await _repository.Post(role);
                if (create > 0)
                {
                    return Ok(role);
                }
                return BadRequest();
            }
        }

    }
}