using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Project001_Final.Application.Features.Commands.Role.CreateRoleCommand;
using Project001_Final.Application.Features.Commands.Role.UpdateRoleCommand;
using Project001_Final.Application.Features.Queries.Role.GetAllRoles;
using Project001_Final.Application.Features.Queries.Role.GetRoleById;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Project001_Final.Webapi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RoleController : ControllerBase
    {
        private readonly IMediator _mediator;

        public RoleController(IMediator mediator)
        {
            _mediator = mediator;
        }
        //[Authorize]
        [HttpGet]
        [Route("Get")]
        public async Task<IActionResult> Get(string searchInput,bool isActive)
        {
            var query = new GetAllRoleQuery()
            {
                SearchInput = searchInput == null || searchInput == "null" ? "" : searchInput,
                IsActive = isActive
            };
            return Ok(await _mediator.Send(query));
        }
        //[Authorize]
        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var query = new GetRoleByIdQuery()
            {
                Id = id
            };
            return Ok(await _mediator.Send(query));
        }
        //[Authorize]
        [HttpPost]
        [Route("Create")]
        public async Task<IActionResult> Create(CreateRoleCommand command)
        {
            return Ok(await _mediator.Send(command));
        }
        //[Authorize]
        [HttpPut]
        [Route("Update")]
        public async Task<IActionResult> Update(UpdateRoleCommand query)
        {
            return Ok(await _mediator.Send(query));
        }
    }
}
